using System;
using System.Collections.Generic;
using System.Text;
using Datastore.Inventory;

namespace Datastore
{
    public class Player : NonPlayerPerson
    {
        public int Level { get; set; }
        public List<Item> Backpack { get; set; }
    }
}
