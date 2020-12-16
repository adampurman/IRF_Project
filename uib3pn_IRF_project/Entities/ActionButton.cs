using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uib3pn_IRF_project.Entities
{
    class ActionButton : Button
    {
        public int _left;
        public int left
        {
            get { return _left; }
            set { _left = value; }
        }
        public string name;
        public string email;
        public string country;
        public string gender;
        public string phone;
        bool _IsEmployee;


        public bool ismodified = false;

        public EmployeesToExport modifiedEmployee = new EmployeesToExport();



        public bool IsEmployee
        {
            get { return _IsEmployee; }
            set
            {
                if (_IsEmployee)
                {
                    MouseDown += ActionButton_MouseDown;
                    Text = "Modify data";
                    BackColor = Color.Green;
                }
                else
                {
                    MouseDown += ActionButton_MouseDown1;
                    Text = "Add data";
                    BackColor = Color.Yellow;
                }

            }
        }

        private void ActionButton_MouseDown1(object sender, MouseEventArgs e)
        {
            /*EmployeeDataForm employeeDataForm = new EmployeeDataForm(name,country,email,"","");
            employeeDataForm.ShowDialog();*/


            using (EmployeeDataForm employeeDataForm = new EmployeeDataForm(name, country, email, "", ""))
            {
                employeeDataForm.ShowDialog();
                modifiedEmployee = employeeDataForm.EmployeeExport;
                ismodified = employeeDataForm.ismodified;

            }
        }

        private void ActionButton_MouseDown(object sender, MouseEventArgs e)
        {
            //EmployeeDataForm employeeDataForm = new EmployeeDataForm(name, country, email, gender, phone);
            using (EmployeeDataForm employeeDataForm = new EmployeeDataForm(name, country, email, gender, phone))
            {
                employeeDataForm.ShowDialog();
                modifiedEmployee = employeeDataForm.EmployeeExport;
                ismodified = employeeDataForm.ismodified;

            }


        }

        public ActionButton()
        {
            Top = 7;
            Left = 400;//_left;
        }
    }
}
