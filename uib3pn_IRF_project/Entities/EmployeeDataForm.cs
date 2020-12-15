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
            nametxt.Text = Name;
            countrytxt.Text = Country;
            emailtxt.Text = Email;
            genderCombo.SelectedItem = gender;
            phonetxt.Text = phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
