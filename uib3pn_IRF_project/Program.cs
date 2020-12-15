using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using uib3pn_IRF_project.Entities;

namespace uib3pn_IRF_project
{
     class Program
    {
        public List<EmployeesToExport> EmployeesToExport = new List<EmployeesToExport>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
