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
        public Form1()
        {
            InitializeComponent();

            var xml = new XmlDocument();
            //xml.LoadXml(GeneratedData);
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"GeneratedData.xml");
            xml.LoadXml(path);

        }
    }
}
