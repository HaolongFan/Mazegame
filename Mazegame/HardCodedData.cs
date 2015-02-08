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
        //Get StrengthstrengthModifier
        public StrengthTable GetStrengthTable()
        {
            return strengthModifier;
        }
        //Get AgilitystrengthModifier
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
            t127 = new Location("a lecture theatre", "T127");
            gregsoffice = new Location("a spinning vortex of terror", "Greg's Office");

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
            startUp.AddNonPlayerCharacter(new NonPlayerCharacter("steven_alan"){ Hostile = true });
            t127.AddNonPlayerCharacter(new NonPlayerCharacter("fred"){ Hostile = false });
        }

        //Creat Items
        private void CreateItems()
        {
            gregsoffice.GetInventory().AddMoney(250);
            gregsoffice.GetInventory().AddItem(new Item("A bag of gold", 2, 1, "A bag full with gold"));
            gregsoffice.GetInventory().AddItem(new Item("final_exam", 2, 1000000000, "The answers to ITECH3201"));

            startUp.GetInventory().AddMoney(300);
            startUp.GetInventory().AddItem(new Item("A bag of gold", 2, 1, "A bag full with gold"));
            startUp.GetInventory().AddItem(new Item("final_exam", 2, 1000000000, "The answers to ITECH3201"));
        }


        //StrengthstrengthModifier   
        private void PopulateStrengthTable()
        {
           strengthModifier = StrengthTable.GetInstance();
           strengthModifier.SetModifier(1, -5);
           strengthModifier.SetModifier(2, -4);
           strengthModifier.SetModifier(3, -4);
           strengthModifier.SetModifier(4, -3);
           strengthModifier.SetModifier(5, -3);
           strengthModifier.SetModifier(6, -2);
           strengthModifier.SetModifier(7, -2);
           strengthModifier.SetModifier(8, -1);
           strengthModifier.SetModifier(9, -1);
           strengthModifier.SetModifier(10, 0);
           strengthModifier.SetModifier(11, 0);
           strengthModifier.SetModifier(12, 1);
           strengthModifier.SetModifier(13, 1);
           strengthModifier.SetModifier(14, 2);
           strengthModifier.SetModifier(15, 2);
           strengthModifier.SetModifier(16, 3);
           strengthModifier.SetModifier(17, 3);
           strengthModifier.SetModifier(18, 4);
           strengthModifier.SetModifier(19, 4);
           strengthModifier.SetModifier(20, 6);
           strengthModifier.SetModifier(21, 6);
           strengthModifier.SetModifier(22, 6);
           strengthModifier.SetModifier(23, 6);
           strengthModifier.SetModifier(24, 6);
           strengthModifier.SetModifier(25, 6);
           strengthModifier.SetModifier(26, 8);
           strengthModifier.SetModifier(27, 8);
           strengthModifier.SetModifier(28, 8);
           strengthModifier.SetModifier(29, 8);
           strengthModifier.SetModifier(30, 10);
           strengthModifier.SetModifier(31, 10);
           strengthModifier.SetModifier(32, 10);
           strengthModifier.SetModifier(33, 10);
           strengthModifier.SetModifier(34, 10);
           strengthModifier.SetModifier(35, 10);
           strengthModifier.SetModifier(36, 12);
           strengthModifier.SetModifier(37, 12);
           strengthModifier.SetModifier(38, 12);
           strengthModifier.SetModifier(39, 12);
           strengthModifier.SetModifier(40, 12);
           strengthModifier.SetModifier(41, 15);
           strengthModifier.SetModifier(42, 15);
           strengthModifier.SetModifier(43, 15);
           strengthModifier.SetModifier(44, 17);
           strengthModifier.SetModifier(45, 17);
           strengthModifier.SetModifier(46, 18);       
        }
        //AgilitystrengthModifier
        private void PopulateAgilityTable()
        {
            agilityModifier = AgilityTable.GetInstance();
            agilityModifier.SetModifier(1, -5);
            agilityModifier.SetModifier(2, -5);
            agilityModifier.SetModifier(3, -5);
            agilityModifier.SetModifier(4, -3);
            agilityModifier.SetModifier(5, -3);
            agilityModifier.SetModifier(6, -2);
            agilityModifier.SetModifier(7, -2);
            agilityModifier.SetModifier(8, -1);
            agilityModifier.SetModifier(9, -1);
            agilityModifier.SetModifier(10, 0);
            agilityModifier.SetModifier(11, 0);
            agilityModifier.SetModifier(12, 1);
            agilityModifier.SetModifier(13, 1);
            agilityModifier.SetModifier(14, 2);
            agilityModifier.SetModifier(15, 2);
            agilityModifier.SetModifier(16, 3);
            agilityModifier.SetModifier(17, 3);
            agilityModifier.SetModifier(18, 4);
            agilityModifier.SetModifier(19, 4);
            agilityModifier.SetModifier(20, 6);
            agilityModifier.SetModifier(21, 6);
            agilityModifier.SetModifier(22, 6);
            agilityModifier.SetModifier(23, 6);
            agilityModifier.SetModifier(24, 6);
            agilityModifier.SetModifier(25, 6);
            agilityModifier.SetModifier(26, 8);
            agilityModifier.SetModifier(27, 8);
            agilityModifier.SetModifier(28, 8);
            agilityModifier.SetModifier(29, 8);
            agilityModifier.SetModifier(30, 8);
            agilityModifier.SetModifier(31, 8);
            agilityModifier.SetModifier(32, 11);
            agilityModifier.SetModifier(33, 11);
            agilityModifier.SetModifier(34, 11);
            agilityModifier.SetModifier(35, 11);
            agilityModifier.SetModifier(36, 11);
            agilityModifier.SetModifier(37, 11);
            agilityModifier.SetModifier(38, 11);
            agilityModifier.SetModifier(39, 11);
            agilityModifier.SetModifier(40, 11);
            agilityModifier.SetModifier(41, 11);
            agilityModifier.SetModifier(42, 11);
            agilityModifier.SetModifier(43, 11);
            agilityModifier.SetModifier(44, 11);
            agilityModifier.SetModifier(45, 11);
            agilityModifier.SetModifier(46, 11);
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