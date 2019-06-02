using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Inventory
{
    /// <summary>
    /// Class for Body armor type
    /// This one is extending from Item.
    /// Its can be placed in inventory or at body type slot
    /// </summary>
    [Serializable]
    public class Body : Item
    {
        public string Type { get; set; }
    }
}
