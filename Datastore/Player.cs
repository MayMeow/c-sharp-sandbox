using System;
using System.Collections.Generic;
using System.Text;
using Datastore.Inventory;

namespace Datastore
{
    /// <summary>
    /// Player Character
    /// Its has everything from NPC and adding Backpack and Level
    /// </summary>
    public class Player : NonPlayerPerson
    {
        public int Level { get; set; }
        public List<Item> Backpack { get; set; }
    }
}
