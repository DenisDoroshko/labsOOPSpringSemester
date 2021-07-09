using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlProcessing;
using EquipmentGuides;

namespace UnitTests
{
    [TestClass]
    public class XmlReaderTest
    {
        [DataTestMethod]
        [DataRow("Car", 2, 257,2015)]
        [DataRow("Phone", 3, 478, 2014)]
        [DataRow("Cutting machine",1, 123, 2021)]
        public void Save(string name,int owner,int cost, int year)
        {
            //Arange
            var expected = new EquipmentGuide();
            expected.EquipmentList.Add(new Equipment(name,(Organizations)owner, cost, year));
            XmlWriter.Save(expected, @"ReaderTest.xml");
            //Act
            var resultGuide=XmlReader.Read(@"ReaderTest.xml");
            //Assert
            Assert.AreEqual(expected, resultGuide);
        }
    }
}
