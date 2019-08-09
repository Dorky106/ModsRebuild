using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Mods
{
    public class Mod
    {
        public readonly string ModName;
        public readonly string ModFolder;
        public readonly Version Version;
        public readonly string UpdateURL;
        public readonly string ConfigLocation;
        public readonly string FileName;
        public readonly List<string> Dependencies;

        public Mod(string modname, string modfolder, Version version, string url, string config, string configfilename, List<string> deps)
        {
            this.ModName = modname;
            this.ModFolder = modfolder;
            this.Version = version;
            this.ConfigLocation = config;
            this.FileName = configfilename;
            this.UpdateURL = url;
            this.Dependencies = deps;
        }
    }
}
