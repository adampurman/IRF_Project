﻿using System;
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
        {get { return _left; }
        set { _left = value; }
        }
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
                    ForeColor = Color.Green;
                }
                else
                {
                    MouseDown += ActionButton_MouseDown1;
                    Text = "Add data";
                    ForeColor = Color.Yellow;
                }

            }
    }

        private void ActionButton_MouseDown1(object sender, MouseEventArgs e)
        {
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(name,country,email,"","");
            employeeDataForm.ShowDialog();
        }

        private void ActionButton_MouseDown(object sender, MouseEventArgs e)
        {
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(name, country, email, gender, phone);
            employeeDataForm.ShowDialog();
        }

        public ActionButton()
        {
            Top = 30;
            Left = 600;//_left;
        }
    }
}
