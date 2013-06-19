using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxMind.GeoIP
{
    static class Version
    {
        public const string AssemblyVersion = "1.2.0";
        public const string AssemblyFileVersion = AssemblyVersion;
        public const string AssemblyInformationalVersion = AssemblyVersion;
        public const bool IsStable = AssemblyInformationalVersion == AssemblyVersion;
    }
}
