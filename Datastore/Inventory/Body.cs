using System;
using System.Collections.Generic;
using System.Text;

namespace Datastore.Inventory
{
    [Serializable]
    public class Body : Item
    {
        public string Type { get; set; }
    }
}
