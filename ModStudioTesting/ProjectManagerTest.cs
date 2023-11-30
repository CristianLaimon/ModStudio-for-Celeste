using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace ModStudioLogic
{
    public class ProjectManagerTests
    {
        [Fact]
        public void AddProject_ShouldAddProjectToList()
        {
            // Arrange
            var projectManager = new ProjectManager();
            var project = new Project();

            // Act
            ProjectManager.AddProject(project);

            // Assert
            ProjectManager.GetLastProjectAdded().Should().Be(project);
        }

        [Fact]
        public void RemoveProject_ShouldRemoveProjectFromList()
        {
            // Arrange
            var projectManager = new ProjectManager();
            var project = new Project();
            ProjectManager.AddProject(project);

            // Act
            ProjectManager.RemoveProject(project);

            // Assert
            ProjectManager.GetLastProjectAdded().Should().NotBe(project);
        }

        [Fact]
        public void GetProjectByPath_ShouldReturnProjectWithGivenPath()
        {
            // Arrange
            var projectManager = new ProjectManager();
            var project = new Project { FullPath = "TestPath" };
            ProjectManager.AddProject(project);

            // Act
            var foundProject = ProjectManager.GetProjectByPath("TestPath");

            // Assert
            foundProject.Should().Be(project);
        }
    }

    public class ProjectTests
    {
        [Fact]
        public void ProjectProperties_ShouldHaveDefaultValues()
        {
            // Arrange
            var project = new Project();

            // Assert
            project.FullPath.Should().BeEmpty();
            project.ModVersion.Should().Be("0.0.1");
            project.ModName.Should().BeEmpty();
            project.AuthorName.Should().BeEmpty();
            project.CampaignName.Should().BeEmpty();
            project.Features.Should().BeEmpty();
        }
    }
}
