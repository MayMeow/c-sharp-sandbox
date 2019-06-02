using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Inventory
{
    /// <summary>
    /// Class for weapons.
    /// This class is extending from Item class
    /// </summary>
    [Serializable]
    public class Weapon : Item
    {
        public int MinDmg { get; set; }
        public int MaxDmb { get; set; }
    }
}
