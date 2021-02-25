using System.Collections.Generic;
using EquipmentGuides;
using System.Xml;

namespace XmlProcessing
{
    /// <summary>
    /// Class for saving data
    /// </summary>
    public static class XmlWriter
    {
        /// <summary>
        /// Saves data to xml file
        /// </summary>
        /// <param name="equipmentGuide">Equipment guide</param>
        /// <param name="path">File path</param>
        
        public static void Save(EquipmentGuide equipmentGuide, string path)
        {
            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("Guide");
            document.AppendChild(root);
            foreach (var equipment in equipmentGuide.EquipmentList)
            {
                var equipmentNode = document.CreateElement("Equipment");
                root.AppendChild(equipmentNode);
                FillEquipmentNode(document, equipmentNode, "Name", equipment.Name);
                FillEquipmentNode(document, equipmentNode, "OwnerOrganization", equipment.OwnerOrganization.ToString());
                FillEquipmentNode(document, equipmentNode, "Cost", equipment.Cost.ToString());
                FillEquipmentNode(document, equipmentNode, "ProductionYear", equipment.ProductionYear.ToString());
            }
            document.Save(path);
        }

        /// <summary>
        /// Fills a equipment node
        /// </summary>
        /// <param name="document">Xml document</param>
        /// <param name="equipmentNode">Node</param>
        /// <param name="name">Name of property</param>
        /// <param name="value">Value of property</param>
        
        private static void FillEquipmentNode(XmlDocument document, XmlElement equipmentNode, string name, string value)
        {
            XmlElement propertyNode = document.CreateElement(name);
            equipmentNode.AppendChild(propertyNode);
            XmlText nodeValue = document.CreateTextNode(value);
            propertyNode.AppendChild(nodeValue);
        }
    }
}
