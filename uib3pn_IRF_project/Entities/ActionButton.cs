using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uib3pn_IRF_project.Entities
{
    class ActionButton:Button
    {
        public int _left;
        public string name;
        public string email;
        public string country;
        public string gender;
        public string phone;
        bool _IsEmployee;
        public bool IsEmployee { get { return _IsEmployee; } set {
                if (_IsEmployee)
                {
                    MouseDown += ActionButton_MouseDown;
                    Text = "Modify data";
                }
                else
                {
                    MouseDown += ActionButton_MouseDown1;
                    Text = "Add data";
                }

            }
    }

        private void ActionButton_MouseDown1(object sender, MouseEventArgs e)
        {
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(name,country,email,"","");
        }

        private void ActionButton_MouseDown(object sender, MouseEventArgs e)
        {
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(name, country, email, gender, phone);
        }

        public ActionButton()
        {
            Top = 30;
            Left = _left;
        }
    }
}
