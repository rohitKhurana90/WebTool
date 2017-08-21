using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTool.Models
{
    public class TestCase
    {
        TestCase() {
            name = "Rohit";
        }
        public String name { get; set; }

        public static TestCase[] getData() {

            TestCase[] a = new TestCase[1];
            a[0] = new TestCase();
            return a;  
       }

    }

}