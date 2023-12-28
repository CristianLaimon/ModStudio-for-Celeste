using Version = ModStudioLogic.Version;

namespace ModStudioLogic.ProyectInside
{
    public struct Dependency
    {
        public string Name;
        public Version Version;

        public Dependency(string name, Version version)
        {
            Name = name;
            Version = version;
        }
    }
}