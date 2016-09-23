using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication_FiguredWebAutomation.Tests;

namespace ConsoleApplication_FiguredWebAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoginTest LoginTestObject = new LoginTest();
            //LoginTestObject.LoginWithValidCredentialTest();

            ShedTrackerTest ShedTrackerTestObject = new ShedTrackerTest();
            ShedTrackerTestObject.ShedTrackerEditTest();
        }
    }
}
