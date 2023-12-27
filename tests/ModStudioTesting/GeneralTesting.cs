using ModStudioLogic;
using ModStudioLogic.Olympus;
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
    }
}