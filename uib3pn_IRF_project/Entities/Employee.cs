﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uib3pn_IRF_project.Entities
{
    class Employee
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public CountryEnum Country { get; set; }
    }
}
