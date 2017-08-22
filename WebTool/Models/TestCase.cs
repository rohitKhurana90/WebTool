using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTool.Models
{
    public class TestCase
    {

        public String TestCaseID { get; set; }
        public String TestCaseName{ get; set; }
        public String IterationType { get; set; }
        public String IterationValue { get; set; }
        public String Run { get; set; }
        public String Status { get; set; }        

    }

}