using System;
using System.Collections.Generic;
using System.Text;
using Datastore.Inventory;

namespace Datastore
{
    /// <summary>
    /// NPC - Non player characters
    /// </summary>
    public class NonPlayerPerson
    {
        public string Name { get; set; }

        public Body Body { get; set; }
    }
}
