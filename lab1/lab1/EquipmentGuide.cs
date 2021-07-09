using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EquipmentGuides
{
    /// <summary>
    /// The class representing a equipment guide
    /// </summary>
    
    public class EquipmentGuide
    {
        /// <summary>
        /// Creates an instance of the EquipmentGuide class
        /// </summary>
        
        public EquipmentGuide()
        {
            EquipmentList = new List<Equipment>();
        }

        /// <summary>
        /// Equipment list
        /// </summary>
        
        public List<Equipment> EquipmentList;

        /// <summary>
        /// Redefining the Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false</returns>

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            EquipmentGuide equipmentGuide = (EquipmentGuide)obj;
            return EquipmentList.SequenceEqual(equipmentGuide.EquipmentList);
        }
    }
}
