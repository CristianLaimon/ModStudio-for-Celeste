using ModStudioLogic.FormsLogic;
using Xunit;

namespace ModStudioLogic
{
    public class ModStudioState
    {
        [Fact]
        public void GetFormattedMessage_DefaultState_ReturnsCorrectMessage()
        {
            // Arrange
            IModStudioState state = new FormStateDefault();

            // Act
            var result = StateFormat.GetFormattedMessage(state);

            // Assert
            Assert.Equal(" --- Running --- ", result);
        }

        [Fact]
        public void GetFormattedMessage_StartupState_ReturnsCorrectMessage()
        {
            // Arrange
            IModStudioState state = new FormStateStartup();

            // Act
            var result = StateFormat.GetFormattedMessage(state);

            // Assert
            Assert.Equal(" --- Startup Completed --- ", result);
        }

        [Fact]
        public void GetFormattedMessage_ChoosingFileState_ReturnsCorrectMessage()
        {
            // Arrange
            IModStudioState state = new FormStateChoosingFile();

            // Act
            var result = StateFormat.GetFormattedMessage(state);

            // Assert
            Assert.Equal(" --- Choosing File --- ", result);
        }

        [Fact]
        public void GetFormattedMessage_ChoosingState_ReturnsCorrectMessage()
        {
            // Arrange
            IModStudioState state = new FormStateChoosing();

            // Act
            var result = StateFormat.GetFormattedMessage(state);

            // Assert
            Assert.Equal(" --- Choosing --- ", result);
        }

        [Fact]
        public void GetFormattedMessage_ChoosingDirectoryState_ReturnsCorrectMessage()
        {
            // Arrange
            IModStudioState state = new FormStateChoosingDirectory();

            // Act
            var result = StateFormat.GetFormattedMessage(state);

            // Assert
            Assert.Equal(" --- Choosing Directory --- ", result);
        }

        [Fact]
        public void GetFormattedMessage_ErrorState_ReturnsCorrectMessage()
        {
            // Arrange
            string errorMessage = "Custom error message";
            IModStudioState state = new FormStateError(errorMessage);

            // Act
            var result = StateFormat.GetFormattedMessage(state);

            // Assert
            Assert.Equal(" --- " + errorMessage + " --- ", result);
        }

        [Fact]
        public void GetFormattedMessage_CreatingProjectState_ReturnsCorrectMessage()
        {
            // Arrange
            IModStudioState state = new FormStateCreatingProject();

            // Act
            var result = StateFormat.GetFormattedMessage(state);

            // Assert
            Assert.Equal(" --- Creating Project --- ", result);
        }
    }
}
