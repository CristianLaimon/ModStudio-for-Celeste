using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModStudioLogic.ProyectInside
{
    public class EverestYaml
    {
        public Version Version;

        private string _projectName;
        private List<Dependency> _dependencies;

        public Dependency[] Dependencies { get => _dependencies.ToArray(); }
        public string ProjectName { get => _projectName; }

        public EverestYaml(string projectName, Version version)
        {
            _projectName = projectName;
            Version = version;
            _dependencies = new List<Dependency>();
            AddEverestDependency();
        }

        public void AddDependency(Dependency dep) => _dependencies.Add(dep);

        public bool RemoveDependency(Dependency dep) => _dependencies.Remove(dep);

        #region Internals

        private void AddEverestDependency()
        {
            Dependency everest = new Dependency("Everest", new Version(1, 3471, 0));
            _dependencies.Add(everest);
        }

        #endregion Internals
    }
}