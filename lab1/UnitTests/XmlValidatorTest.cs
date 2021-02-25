using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlProcessing;
using EquipmentGuides;
using System.Xml.Serialization;

namespace UnitTests
{
    [TestClass]
    public class XmlValidatorTest
    {
        [DataTestMethod]
        [DataRow(false,-100, 2020)]
        [DataRow(true, 10, 2021)]
        [DataRow(false, 121, -11)]
        public void ValidateXml(bool expected,int cost,int year)
        {
            //Arange
            var guide = new EquipmentGuide();
            guide.EquipmentList.Add(new Equipment("Machine", Organizations.MAZ, cost, year));
            //Act
            XmlWriter.Save(guide, @"ValidationTest.xml");
            var result=XmlValidator.ValidateXml(@"ValidationTest.xml", @"..\..\..\xsdSchema.xsd");
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
