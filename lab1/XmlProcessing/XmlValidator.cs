using System;
using System.Xml.Linq;
using System.Xml.Schema;

namespace XmlProcessing
{
    /// <summary>
    /// Class for validating xml documents
    /// </summary>
    
    public static class XmlValidator
    {
        /// <summary>
        /// Checks the file against the schema
        /// </summary>
        /// <param name="xmlPath">Path to xml file</param>
        /// <param name="schemaPath">Path to schema</param>
        /// <returns>Validation result</returns>
        
        public static bool ValidateXml(string xmlPath,string schemaPath)
        {
            bool validationResult = true;
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add(null, $@"{schemaPath}");
            try
            {
                XDocument document = XDocument.Load($@"{xmlPath}");
                ValidationEventHandler handler = (sender, validationEventArgs) => validationResult = false;
                document.Validate(schema, handler);
            }
            catch
            {
                validationResult = false;
            }
            return validationResult;
        }
    }
}
