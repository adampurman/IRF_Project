using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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
            this.Close();
            
        }

        private void genderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            malepanel.Controls.Clear();
            femalepanel.Controls.Clear();
            if ((string)genderCombo.SelectedItem == "Male")
            {

                var malehead = new head();
                var malebody = new body();
                malehead.BackColor = Color.Blue;
                malebody.BackColor = Color.Blue;
                malepanel.Controls.Add(malehead);
                malepanel.Controls.Add(malebody);

            }
            else
            {
                var femalehead = new head();
                var femalebody = new body();
                femalehead.BackColor = Color.Pink;
                femalebody.BackColor = Color.Pink;
                femalepanel.Controls.Add(femalehead);
                femalepanel.Controls.Add(femalebody);
            }
        }
    }
}
