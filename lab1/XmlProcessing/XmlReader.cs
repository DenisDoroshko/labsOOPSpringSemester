using EquipmentGuides;
using System.Xml;
using System;
using System.Globalization;

namespace XmlProcessing
{
    /// <summary>
    /// Class for getting data from xml file
    /// </summary>
    
    public static class XmlReader
    {
        /// <summary>
        /// Gets data from xml file
        /// </summary>
        /// <param name="xmlPath">Path to xml file</param>
        /// <returns>Equipment guide</returns>
        
        public static EquipmentGuide Read(string xmlPath)
        {
            var equipmentGuide = new EquipmentGuide();
            XmlDocument document = new XmlDocument();
            document.Load(xmlPath);
            XmlElement root = document.DocumentElement;
            foreach (XmlNode equipmentNode in root)
            {
                string name=equipmentNode.ChildNodes[0].InnerText;
                string owner = equipmentNode.ChildNodes[1].InnerText;
                string cost = equipmentNode.ChildNodes[2].InnerText;
                string year = equipmentNode.ChildNodes[3].InnerText;
                equipmentGuide.EquipmentList.Add(ConvertFromStrings(name, owner, cost, year));
            }
            return equipmentGuide;
        }

        /// <summary>
        /// Creates an instance of the equipment class from string data
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="stringOwner">Onwer</param>
        /// <param name="stringCost">Cost</param>
        /// <param name="stringYear">Year</param>
        /// <returns>Instance of the equipment class</returns>
        
        private static Equipment ConvertFromStrings(string name,string stringOwner,string stringCost,string stringYear)
        {
            var owner = (Organizations)Enum.Parse(typeof(Organizations), stringOwner);
            var cost = double.Parse(stringCost.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                CultureInfo.InvariantCulture);
            var year = int.Parse(stringYear);
            return new Equipment(name,owner ,cost,year);
        }
    }
}
