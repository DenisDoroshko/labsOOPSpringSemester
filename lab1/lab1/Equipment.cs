using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentGuides
{
    /// <summary>
    /// The class representing a equipment
    /// </summary>
    
    public class Equipment
    {
        /// <summary>
        /// Creates an instance of the Equipment class
        /// </summary>
        
        public Equipment()
        {
        }

        /// <summary>
        /// Creates an instance of the Equipment class
        /// </summary>
        /// <param name="name">Name of the equipment</param>
        /// <param name="ownerOrganization">Owner organization</param>
        /// <param name="cost">Cost</param>
        /// <param name="productionYear">Production year</param>
        
        public Equipment(string name,Organizations ownerOrganization,double cost,int productionYear)
        {
            Name = name;
            OwnerOrganization = ownerOrganization;
            Cost = cost;
            ProductionYear = productionYear;
        }

        /// <summary>
        /// Name of the equipment
        /// </summary>
        
        public string Name { get; set; }

        /// <summary>
        /// Owner organization
        /// </summary>
        
        public Organizations OwnerOrganization { get; set; }

        /// <summary>
        /// Cost
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Production year
        /// </summary>
        
        public int ProductionYear { get; set; }

        /// <summary>
        /// Redefining the Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false</returns>
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Equipment equipment = (Equipment)obj;
            return Name==equipment.Name && OwnerOrganization==equipment.OwnerOrganization&&
                Cost==equipment.Cost && ProductionYear==equipment.ProductionYear;
        }
    }
}
