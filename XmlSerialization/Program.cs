﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Datastore;
using Datastore.Inventory;

namespace XmlSerialization
{
    class Program
    {
        /// <summary>
        /// Shows how Xml Serialization works
        /// </summary>
        static void Main()
        {
            Console.WriteLine("XML Serialization Example");

            // Create data to serialize
            // See the Body idem can be placed in body or in inventory ;)
            Player player = new Player()
            {
                Body = new Body {Name = "Armor +1", Type = "Leather armor"},
                Level = 10,
                Name = "Aragorn"
            };

            player.Backpack = new List<Item>();
            player.Backpack.Add(new Body
            {
                Name = "Armor +1",
                Type = "Plate Armor"
            });

            player.Backpack.Add(new Weapon
            {
                Name = "Sword +1",
                MinDmg = 1,
                MaxDmb = 4
            });

            // Serialize data and write them to console
            XmlSerializer xs = new XmlSerializer(typeof(Player), new Type[]
            {
                typeof(Weapon),
                typeof(Body)
            });
            StringWriter sw = new StringWriter();
            xs.Serialize(sw,player);

            Console.WriteLine(sw.ToString());
            Console.Read();

        }
    }
}
