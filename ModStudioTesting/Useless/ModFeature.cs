using FluentAssertions;
using ModStudioLogic.BigClasses;
using Xunit;

namespace ModStudioTesting.Useless
{
    public class ModFeatures
    {
        [Fact]
        public void FeatureMaps_FolderName_ReturnsMaps()
        {
            // Arrange
            ModFeature modFeature = new ModFeatureMaps();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Maps");
        }

        [Fact]
        public void FeatureDialog_FolderName_ReturnsDialog()
        {
            // Arrange
            ModFeature modFeature = new ModFeatureDialog();

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
            ModFeature modFeature = new ModFeatureAhorn();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Ahorn");
        }

        [Fact]
        public void FeatureLoenn_FolderName_ReturnsLoenn()
        {
            // Arrange
            ModFeature modFeature = new ModFeatureLoenn();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("Loenn");
        }

        [Fact]
        public void FeatureDLL_FolderName_ReturnsBin()
        {
            // Arrange
            ModFeature modFeature = new ModFeatureDLL();

            // Act
            string result = modFeature.FolderName;

            // Assert
            result.Should().Be("bin");
        }

        [Fact]
        public void FeatureAudio_FolderName_ReturnsAudio()
        {
            // Arrange
            ModFeature modFeature = new ModFeatureAudio();

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
        [InlineData("maps", typeof(ModFeatureMaps))]
        [InlineData("dialog", typeof(ModFeatureDialog))]
        [InlineData("graphics", typeof(FeatureGraphics))]
        [InlineData("ahorn", typeof(ModFeatureAhorn))]
        [InlineData("loenn", typeof(ModFeatureLoenn))]
        [InlineData("dll", typeof(ModFeatureDLL))]
        [InlineData("audio", typeof(ModFeatureAudio))]
        public void ModFeatureFactory_GetFeatureByName_ValidName_ReturnsCorrectType(string featureName, Type expectedType)
        {
            // Act
            ModFeature result = ModFeatureFactory.GetFeatureByName(featureName);

            // Assert
            result.Should().BeOfType(expectedType);
        }
    }
}