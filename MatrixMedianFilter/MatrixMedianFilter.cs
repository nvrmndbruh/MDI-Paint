using PluginInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;

namespace MatrixMedianFilter
{
    [Version(3, 0)]
    public class MatrixMedianFilter : IPlugin
    {
        public string Name => "Матричный медианный фильтр";
        public string Author => "Князев Антон";

        public async Task Transform(Bitmap bitmap, IProgress<int> progress, CancellationToken cancellationToken)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            var rect = new Rectangle(0, 0, width, height);

            // Чтение данных
            var copyData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int stride = copyData.Stride;
            int bytes = Math.Abs(stride) * height;
            byte[] src = new byte[bytes];
            byte[] dst = new byte[bytes];
            Marshal.Copy(copyData.Scan0, src, 0, bytes);
            bitmap.UnlockBits(copyData);

            // Копируем исходные данные, чтобы границы сохранялись
            Array.Copy(src, dst, bytes);

            // Обработка
            await Task.Run(() =>
            {
                int offset = 3;
                for (int x = 1; x < width - 1; x++)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    for (int y = 1; y < height - 1; y++)
                    {
                        // собираем 9 значений для каждого канала
                        var bList = new List<byte>(9);
                        var gList = new List<byte>(9);
                        var rList = new List<byte>(9);

                        for (int j = -1; j <= 1; j++)
                            for (int i = -1; i <= 1; i++)
                            {
                                int px = x + i;
                                int py = y + j;
                                int idx = py * stride + px * offset;
                                bList.Add(src[idx]);       // Blue
                                gList.Add(src[idx + 1]);   // Green
                                rList.Add(src[idx + 2]);   // Red
                            }

                        bList.Sort();
                        gList.Sort();
                        rList.Sort();
                        byte medB = bList[4];
                        byte medG = gList[4];
                        byte medR = rList[4];

                        int dstIdx = y * stride + x * offset;
                        dst[dstIdx] = medB;
                        dst[dstIdx + 1] = medG;
                        dst[dstIdx + 2] = medR;
                    }

                    // прогресс
                    progress.Report((int)((x - 1) * 100.0 / (width)));
                }
            }, cancellationToken);

            // Запись результатов
            var origData = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            Marshal.Copy(dst, 0, origData.Scan0, bytes);
            bitmap.UnlockBits(origData);
        }
    }
}
