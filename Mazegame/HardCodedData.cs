///////////////////////////////////////////////////////////
//  HardCodedData.cs
//  Implementation of the Class HardCodedData
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////

using System;
using Mazegame.Boundary;
using Mazegame.Entity;
using Mazegame.Entity.Utility;
using System.Collections.Generic;


namespace Mazegame
{
    public class HardCodedData : IMazeData
    {
        private Location startUp, lounge,t127,gregsoffice;
        private AgilityTable agilityModifier;
        private StrengthTable strengthModifier;
        private WeightLimit weightLookup;

        public HardCodedData()
        {
            createLocations();
            PopulateAgilityTable();
            PopulateStrengthTable();
            PopulateWeightLimit();
            CreateItems();
            CreateCharacters();

        }

        ~HardCodedData()
        {
        }


        public virtual void Dispose()
        {
        }

        

        public Location GetStartingLocation()
        {
            return startUp;
        }
        //Get Strength Table
        public StrengthTable GetStrengthTable()
        {
            return strengthModifier;
        }
        //Get Agility Table
        public AgilityTable GetAgilityTable()
        {
            return agilityModifier;
        }
        //Get Weight Limit
        public WeightLimit GetWeightLimit()
        {
            return weightLookup;
        }

        public String GetWelcomeMessage()
        {
            return "Welcome to the Mount Helanous";
        }

       


        private void createLocations()
        {
            startUp =
                new Location("an office with paper strewn everywhere, how anyone works effectively here is a mystery",
                    "Julies Office");
            Location lounge =
                new Location("an open space containing comfortable looking couches and artwork of dubious quality",
                    "Airport Lounge");
            Location t127 = new Location("a lecture theatre", "T127");
            Location gregsoffice = new Location("a spinning vortex of terror", "Greg's Office");

            startUp.AddExit("south", new Exit("you see an open space to the south", lounge));
            lounge.AddExit("north", new Exit("you see a mound of paper to the north", startUp));

            startUp.AddExit("west", new Exit("you see a terrifying office to the west", gregsoffice));
           gregsoffice.AddExit("east", new Exit("you see a mound of paper to the east", startUp));

            t127.AddExit("south", new Exit("you see a mound of paper to the south", startUp));
            startUp.AddExit("north", new Exit("you see a bleak place to the north", t127));

            lounge.AddExit("northwest", new Exit("you see a terrifying office to the northwest", gregsoffice));
            gregsoffice.AddExit("southeast", new Exit("you see an open space to the southeast", lounge));
        }

        //Create Characters
        private void CreateCharacters()
        {
            NonPlayerCharacter fred = new NonPlayerCharacter("fred");
            t127.AddNonPlayerCharacter(fred);
        }

        //Creat Items
        private void CreateItems()
        {
            gregsoffice.GetInventory().AddMoney(250);
            gregsoffice.GetInventory().AddItem(new Item("A bag of gold", 2, 1, "A bag full with gold"));
            gregsoffice.GetInventory().AddItem(new Item("final_exam", 2, 1000000000, "The answers to ITECH3201"));
        }


        //Strength Table   
        private void PopulateStrengthTable()
        {
            StrengthTable table = StrengthTable.GetInstance();
            table.SetModifier(1, -5);
            table.SetModifier(2, -4);
            table.SetModifier(3, -4);
            table.SetModifier(4, -3);
            table.SetModifier(5, -3);
            table.SetModifier(6, -2);
            table.SetModifier(7, -2);
            table.SetModifier(8, -1);
            table.SetModifier(9, -1);
            table.SetModifier(10, 0);
            table.SetModifier(11, 0);
            table.SetModifier(12, 1);
            table.SetModifier(13, 1);
            table.SetModifier(14, 2);
            table.SetModifier(15, 2);
            table.SetModifier(16, 3);
            table.SetModifier(17, 3);
            table.SetModifier(18, 4);
            table.SetModifier(19, 4);
            table.SetModifier(20, 6);
            table.SetModifier(21, 6);
            table.SetModifier(22, 6);
            table.SetModifier(23, 6);
            table.SetModifier(24, 6);
            table.SetModifier(25, 6);
            table.SetModifier(26, 8);
            table.SetModifier(27, 8);
            table.SetModifier(28, 8);
            table.SetModifier(29, 8);
            table.SetModifier(30, 10);
            table.SetModifier(31, 10);
            table.SetModifier(32, 10);
            table.SetModifier(33, 10);
            table.SetModifier(34, 10);
            table.SetModifier(35, 10);
            table.SetModifier(36, 12);
            table.SetModifier(37, 12);
            table.SetModifier(38, 12);
            table.SetModifier(39, 12);
            table.SetModifier(40, 12);
            table.SetModifier(41, 15);
            table.SetModifier(42, 15);
            table.SetModifier(43, 15);
            table.SetModifier(44, 17);
            table.SetModifier(45, 17);
            table.SetModifier(46, 18);       
        }
        //Agility Table
            private void PopulateAgilityTable()
            {
                AgilityTable table = AgilityTable.GetInstance();
                table.SetModifier(1, -5);
                table.SetModifier(2, -5);
                table.SetModifier(3, -5);
                table.SetModifier(4, -3);
                table.SetModifier(5, -3);
                table.SetModifier(6, -2);
                table.SetModifier(7, -2);
                table.SetModifier(8, -1);
                table.SetModifier(9, -1);
                table.SetModifier(10, 0);
                table.SetModifier(11, 0);
                table.SetModifier(12, 1);
                table.SetModifier(13, 1);
                table.SetModifier(14, 2);
                table.SetModifier(15, 2);
                table.SetModifier(16, 3);
                table.SetModifier(17, 3);
                table.SetModifier(18, 4);
                table.SetModifier(19, 4);
                table.SetModifier(20, 6);
                table.SetModifier(21, 6);
                table.SetModifier(22, 6);
                table.SetModifier(23, 6);
                table.SetModifier(24, 6);
                table.SetModifier(25, 6);
                table.SetModifier(26, 8);
                table.SetModifier(27, 8);
                table.SetModifier(28, 8);
                table.SetModifier(29, 8);
                table.SetModifier(30, 8);
                table.SetModifier(31, 8);
                table.SetModifier(32, 11);
                table.SetModifier(33, 11);
                table.SetModifier(34, 11);
                table.SetModifier(35, 11);
                table.SetModifier(36, 11);
                table.SetModifier(37, 11);
                table.SetModifier(38, 11);
                table.SetModifier(39, 11);
                table.SetModifier(40, 11);
                table.SetModifier(41, 11);
                table.SetModifier(42, 11);
                table.SetModifier(43, 11);
                table.SetModifier(44, 11);
                table.SetModifier(45, 11);
                table.SetModifier(46, 11);
            }
        //Weight Limit
            private void PopulateWeightLimit()
            {
                weightLookup = WeightLimit.GetInstance();
                weightLookup.SetModifier(1, 6);
                weightLookup.SetModifier(2, 13);
                weightLookup.SetModifier(3, 20);
                weightLookup.SetModifier(4, 26);
                weightLookup.SetModifier(5, 33);
                weightLookup.SetModifier(6, 40);
                weightLookup.SetModifier(7, 46);
                weightLookup.SetModifier(8, 53);
                weightLookup.SetModifier(9, 60);
                weightLookup.SetModifier(10, 66);
                weightLookup.SetModifier(11, 76);
                weightLookup.SetModifier(12, 86);
                weightLookup.SetModifier(13, 100);
                weightLookup.SetModifier(14, 116);
                weightLookup.SetModifier(15, 133);
                weightLookup.SetModifier(16, 153);
                weightLookup.SetModifier(17, 173);
                weightLookup.SetModifier(18, 200);
                weightLookup.SetModifier(19, 233);
                weightLookup.SetModifier(20, 266);
                weightLookup.SetModifier(21, 306);
                weightLookup.SetModifier(22, 346);
                weightLookup.SetModifier(23, 400);
                weightLookup.SetModifier(24, 466);
                weightLookup.SetModifier(25, 533);
                weightLookup.SetModifier(26, 613);
                weightLookup.SetModifier(27, 693);
                weightLookup.SetModifier(28, 800);
                weightLookup.SetModifier(29, 933);
            }


        
    } //end HardCodedData
} //end namespace Mazegame