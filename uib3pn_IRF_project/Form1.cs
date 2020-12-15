using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using uib3pn_IRF_project.Entities;

namespace uib3pn_IRF_project
{
    public partial class Form1 : Form
    {
        List<Employee> Employees = new List<Employee>();
        String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"GeneratedData.xml");
        List<EmployeesToExport> EmployeesToExport=new List<EmployeesToExport>();
        public Form1()
        {
          //  EmployeesToExport = new List<EmployeesToExport>();
            InitializeComponent();
           /* using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string xmlFile = sr.ReadLine();
            }*/
            var xml = new XmlDocument();
            //xml.LoadXml(GeneratedData);
            
            xml.Load(path);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var newemployee = new Employee();
                Employees.Add(newemployee);
                // MessageBox.Show(element.GetAttribute("Country"));
                var country = (XmlElement)element.ChildNodes[2];
                var name = (XmlElement)element.ChildNodes[0];
                var email = (XmlElement)element.ChildNodes[1];
                newemployee.Country = (CountryEnum)Enum.Parse(typeof (CountryEnum),country.InnerText);
                newemployee.FirstName = name.InnerText;
                newemployee.Email = email.InnerText;
                    //(Employee)Enum.Parse(typeof(Employee), element.GetAttribute("Country"));
            }
            dataGridView1.DataSource = Employees;
            comboBox1.Items.Clear();
            foreach  (var item in Employees)
            {
                EmployeesToExport.Add(new EmployeesToExport(){ 
                FirstName=item.FirstName,
                Country=item.Country,
                Email=item.Email,
                gender="",
                phone=""
                });
                comboBox1.Items.Add(item.FirstName);

            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionButton actionbutton = new ActionButton();
            foreach (ActionButton item in panel1.Controls.OfType<ActionButton>())
            {
                
                panel1.Controls.Remove(item);
                item.Dispose();
            }
            panel1.Controls.Add(actionbutton);
            var EmployeeData = (from x in EmployeesToExport where x.FirstName == (string)comboBox1.SelectedItem select x).FirstOrDefault();
            if (EmployeeData.phone=="")
            {
                actionbutton.IsEmployee = false;
            }
            else
            {
                actionbutton.IsEmployee = true;
            }
            actionbutton._left = dataGridView1.Width + 10+dataGridView1.Left;
            actionbutton.name = EmployeeData.FirstName;
            actionbutton.email = EmployeeData.Email;
            actionbutton.country = EmployeeData.Country.ToString();
            actionbutton.gender = EmployeeData.gender;
            actionbutton.phone = EmployeeData.phone;



        }
    }
}
