using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractise.DataDrivenTesting
{
    [TestClass]
    public class SampleTest
    {
        [DataTestMethod]
        [DataRow("lakshmi","bangalore")]
        [DataRow("chitra","Madurai")]
        [TestMethod]
        [Priority(1)]
        public void TestMethod(string name,string place)
        {
            Console.WriteLine("Data 1: " + name + "Data 2 : " + place);
        }
        [TestInitialize]
        public void TestInitialize() 
        {
            Console.WriteLine("Test Started");
        }
        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine("Test method ended");
        }
    }
}
