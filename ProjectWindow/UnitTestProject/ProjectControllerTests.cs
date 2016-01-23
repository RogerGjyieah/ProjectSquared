using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;
using Models;

namespace UnitTestProject
{
    [TestClass]
    public class ProjectControllerTests
    {
        private ProjectController controller;

        [TestInitialize]
        public void Init()
        {
            controller = ProjectController.GetInstance();
        }

        [TestMethod]
        public void NewProjectTest()
        {
            string projectName = "testProjectName";
            Uri location = new Uri(@"C:\projects\");

            Member creator = new Member("testName");
            Project testProject = new Project(creator, projectName, location);


            controller.NewProject(testProject);

            Project[] projects = controller.GetProjects();
            int index = -2;
            Assert.IsTrue(ContainsProject(projects, testProject, out index), "Project Controller evidently not containing newly generated project");
            Assert.AreEqual(controller.GetProjects()[index].Creator, creator);
        }

        private bool ContainsProject(Project[] haystack, Project needle, out int index)
        {
            bool found = false;
            index = 0;

            while (!found && index < haystack.Length)
            {
                found = haystack[index].Equals(needle);
                if (!found)
                {
                    index++;
                }
            }

            if (!found)
            {
                index = -1;
            }

            return found;
        }
    }
}
