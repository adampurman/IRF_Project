using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uib3pn_IRF_project.Entities
{
    public partial class EmployeeDataForm : Form
    {
        public EmployeeDataForm(string Name, string Country, string Email,string gender, string phone)
        {
            InitializeComponent();
        }
    }
}
