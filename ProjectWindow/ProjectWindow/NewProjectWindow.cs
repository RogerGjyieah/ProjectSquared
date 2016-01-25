using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWindow
{
    public partial class NewProjectWindow : Form
    {
        private Action<bool, Project> callback;
        public NewProjectWindow(Action<bool, Project> callback)
        {
            InitializeComponent();
            this.callback = callback;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //TODO validate fields
            string creatorName = cbCreator.SelectedText;
            string projectName = txtProjectName.Text;

            Uri projectUri = new Uri(txtProjectUri.Text);

            Project res = new Project("UItest_project", new Member("UItest_member", creatorName), projectName, projectUri);

            Controllers.ProjectController.GetInstance().NewProject(res);

            callback(true, res);
            //TODO add try catch with a callback(false, null);
            this.Dispose();
        }
    }
}
