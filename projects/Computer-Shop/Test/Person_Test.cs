using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace Test
{
    [TestClass]
    public class Person_Test
    {
        [TestMethod]
        public void Main()
        {
            //arrange
            Person objPerson = new Person("Name1", "Email1", 06123456);

            //act
            objPerson.Email = "Email12";

            //assert
            Assert.AreEqual(objPerson.Email, "Email12");
        }
    }
}
