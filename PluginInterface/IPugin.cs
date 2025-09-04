using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace PluginInterface
{
    public interface IPlugin
    {
        string Name { get; }
        string Author { get; }
        Task Transform(Bitmap app, IProgress<int> progress, CancellationToken cancellationToken);
    }

    public class VersionAttribute : Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }
        public VersionAttribute(int major, int minor)
        {
            Major = major;
            Minor = minor;
        }
    }
    public class PluginConfigEntry
    {
        public string Path { get; set; }
        public bool Enabled { get; set; }
        public string Version { get; set; }
    }

    public class PluginsConfiguration
    {
        public bool AutoMode { get; set; }
        public List<PluginConfigEntry> Plugins { get; set; } = new List<PluginConfigEntry>();
    }
}
