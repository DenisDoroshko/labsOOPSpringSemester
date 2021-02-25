using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlProcessing;
using EquipmentGuides;

namespace UnitTests
{
    [TestClass]
    public class XmlWriterTest
    {
        [DataTestMethod]
        [DataRow("Machine", 1, 1232, 2020)]
        [DataRow("Fridge", 2, 500, 2019)]
        [DataRow("Phone", 4, 4566, 2014)]
        public void Save(string name, int owner, int cost, int year)
        {
            //Arange
            var expected = new EquipmentGuide();
            expected.EquipmentList.Add(new Equipment(name, (Organizations)owner, cost, year));
            XmlWriter.Save(expected, @"WriterTest.xml");
            //Act
            var resultGuide = XmlReader.Read(@"WriterTest.xml");
            //Assert
            Assert.AreEqual(expected, resultGuide);
        }
    }
}
