﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.model
{
    public class EmployeeMiscellaneous
    {
        public int id { get; set; }
        public Employee employee { get; set; }
        public Miscellaneous miscellaneous { get; set; }
    }
}
