using CelesteModStudioGUI.Model;
using FluentAssertions;
using Xunit;

namespace ModStudioLogic
{
    public class ModFeatures
    {

        [Fact]
        public void FeatureMaps_FolderName_ReturnsMaps()
        {
            // Arrange
            ModFeature modFeature = new FeatureMaps();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Maps");
        }

        [Fact]
        public void FeatureDialog_FolderName_ReturnsDialog()
        {
            // Arrange
            ModFeature modFeature = new FeatureDialog();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Dialog");
        }

        [Fact]
        public void FeatureGraphics_FolderName_ReturnsGraphics()
        {
            // Arrange
            ModFeature modFeature = new FeatureGraphics();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Graphics");
        }

        [Fact]
        public void FeatureAhorn_FolderName_ReturnsAhorn()
        {
            // Arrange
            ModFeature modFeature = new FeatureAhorn();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Ahorn");
        }

        [Fact]
        public void FeatureLoenn_FolderName_ReturnsLoenn()
        {
            // Arrange
            ModFeature modFeature = new FeatureLoenn();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Loenn");
        }

        [Fact]
        public void FeatureDLL_FolderName_ReturnsBin()
        {
            // Arrange
            ModFeature modFeature = new FeatureDLL();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("bin");
        }

        [Fact]
        public void FeatureAudio_FolderName_ReturnsAudio()
        {
            // Arrange
            ModFeature modFeature = new FeatureAudio();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Audio");
        }

        [Fact]
        public void ModFeatureFactory_GetFeatureByName_Default_ReturnsModFeature()
        {
            // Arrange
            string featureName = "unknown";

            // Act
            ModFeature result = ModFeatureFactory.GetFeatureByName(featureName);

            // Assert
            result.Should().BeOfType<ModFeature>();
        }

        [Theory]
        [InlineData("maps", typeof(FeatureMaps))]
        [InlineData("dialog", typeof(FeatureDialog))]
        [InlineData("graphics", typeof(FeatureGraphics))]
        [InlineData("ahorn", typeof(FeatureAhorn))]
        [InlineData("loenn", typeof(FeatureLoenn))]
        [InlineData("dll", typeof(FeatureDLL))]
        [InlineData("audio", typeof(FeatureAudio))]
        public void ModFeatureFactory_GetFeatureByName_ValidName_ReturnsCorrectType(string featureName, Type expectedType)
        {
            // Act
            ModFeature result = ModFeatureFactory.GetFeatureByName(featureName);

            // Assert
            result.Should().BeOfType(expectedType);
        }
    }
}
