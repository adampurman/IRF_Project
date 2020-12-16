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
using uib3pn_IRF_project.Entities;

namespace uib3pn_IRF_project.Entities
{
    public partial class EmployeeDataForm : Form
    {
        public EmployeesToExport EmployeeExport = new EmployeesToExport();
        public bool ismodified = false;
        public EmployeeDataForm(string Name, string Country, string Email, string gender, string phone)
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
            EmployeeExport.FirstName = nametxt.Text;
            EmployeeExport.Email = emailtxt.Text;
            EmployeeExport.Country = (CountryEnum)Enum.Parse(typeof(CountryEnum), countrytxt.Text);
            EmployeeExport.gender = genderCombo.SelectedItem.ToString();
            EmployeeExport.phone = phonetxt.Text;
            ismodified = true;


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
                malepanel.Controls.Add(malehead);
                malepanel.Controls.Add(malebody);

            }
            else
            {
                var femalehead = new femalehead();
                var femalebody = new femalebody();
                malepanel.Controls.Add(femalehead);
                malepanel.Controls.Add(femalebody);
            }
        }
    }
}
