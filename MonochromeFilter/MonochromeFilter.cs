using PluginInterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MonochromeFilter
{
    [Version(2, 1)]
    public class MonochromeFilter : IPlugin
    {
        public string Name { get => "Оттенки серого"; }

        public string Author { get => "Князев Антон"; }

        public async Task Transform(Bitmap bitmap, IProgress<int> progress, CancellationToken cancellationToken)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            var rect = new Rectangle(0, 0, width, height);

            // чтение данных изображения
            var copyData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int stride = copyData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] src = new byte[bytes];
            byte[] dst = new byte[bytes];
            Marshal.Copy(copyData.Scan0, src, 0, bytes);
            bitmap.UnlockBits(copyData);

            // Копируем исходные данные
            Array.Copy(src, dst, bytes);

            // Обработка изображения
            await Task.Run(() =>
            {
                for (int y = 0; y < height; y++)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    for (int x = 0; x < width; x++)
                    {
                        // Вычисляем индекс текущего пикселя в массиве
                        int idx = y * stride + x;

                        // Получаем значения каналов RGB
                        byte b = src[idx];       // Blue
                        byte g = src[idx + 1];   // Green
                        byte r = src[idx + 2];   // Red

                        // Преобразуем в черно-белое с использованием весовых коэффициентов
                        byte gray = (byte)(0.299 * r + 0.587 * g + 0.114 * b);

                        // Записываем результат в каждый канал
                        dst[idx] = gray;       // Blue
                        dst[idx + 1] = gray;   // Green
                        dst[idx + 2] = gray;   // Red
                    }

                    // Отчет о прогрессе
                    progress.Report((int)(y * 100.0 / height));
                }
            }, cancellationToken);

            // Запись результатов обратно в изображение
            var origData = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            Marshal.Copy(dst, 0, origData.Scan0, bytes);
            bitmap.UnlockBits(origData);
        }
    }
}
