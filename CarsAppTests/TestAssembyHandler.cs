using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarsAppTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestAssembyHandler
    {

        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            context.WriteLine("Assembly init");
        }

        [AssemblyCleanup]
        public static void Cleanup()
        {

        }



    }
}
