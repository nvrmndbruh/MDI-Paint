using PluginInterface;
using System;
using System.Device.Location;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace LocationAndTime
{
    [Version(1, 3)]
    public class LocationAndTime : IPlugin
    {
        public string Name => "Локация и время";
        public string Author => "Князев Антон";
        public async Task Transform(Bitmap bitmap, IProgress<int> progress, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                // проверка на отмену
                cancellationToken.ThrowIfCancellationRequested();

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    string text = $"{DateTime.Now} {GetLocationProperty()}";
                    g.DrawString(text, new Font("Arial", 12), new SolidBrush(Color.Red), bitmap.Width - 400, bitmap.Height - 50);
                }

                // сообщаем о завершении
                progress?.Report(100);
            }, cancellationToken);
        }

        static string GetLocationProperty()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                return $"Lat: {coord.Latitude}, Long: {coord.Longitude}";
            }
            else
            {
                return "Unknown latitude and longitude.";
            }
        }
    }
}
