using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModStudioLogic.ProyectInside
{
    public class Version
    {
        public int MayorVersion;
        public int MinorVersion;
        public int PatchVersion;

        public Version(int mayor = 0, int minor = 1, int patch = 0)
        {
            MayorVersion = mayor;
            MinorVersion = minor;
            PatchVersion = patch;
        }

        public override string ToString()
        {
            return MayorVersion + "." + MinorVersion + "." + PatchVersion;
        }
    }
}