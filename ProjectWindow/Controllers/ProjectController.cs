using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ProjectController
    {
        private static ProjectController instance;

        private List<Project> projects;

        private ProjectController()
        {
            projects = new List<Project>();
        }

        public static ProjectController GetInstance()
        {
            if (instance == null)
            {
                instance = new ProjectController();
            }

            return instance;
        }

        public void NewProject(Project p)
        {
            projects.Add(p);
        }

        public Project[] GetProjects()
        {
            return projects.ToArray();
        }
    }
}
