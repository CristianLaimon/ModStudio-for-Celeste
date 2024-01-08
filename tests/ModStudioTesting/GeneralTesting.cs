using ModStudioLogic;
using ModStudioLogic.BigClasses;
using ModStudioLogic.Olympus;
using ModStudioLogic.ProjectInside;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ModStudioTesting
{
    public class GeneralTesting
    {
        [Fact]
        private void DefaultOlympusPath_returnsbool()
        {
            //This will work on machines with everest installed
            Assert.True(Olympus.CheckIfInstalledDefault());
        }

        [Fact]
        private void DefaultLoennPath_returnsbool()
        {
            Assert.True(Loenn.CheckIfInstalledDefault());
        }

        [Fact]
        private void FindSpecificType_returnsbool()
        {
            Project sample = TemplatesProjects.GetSimpleProject();
            Projects.AddProject(sample);
            bool v = Projects.CheckIfHasFeature(sample, typeof(ModFeatureMaps));
            Assert.True(v);
        }
    }
}