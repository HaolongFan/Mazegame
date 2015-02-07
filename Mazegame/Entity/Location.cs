///////////////////////////////////////////////////////////
//  Location.cs
//  Implementation of the Class Location
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////


using System;
using System.Collections;
using System.Text;
using Mazegame.Entity.Utility;


namespace Mazegame.Entity
{
    public class Location
    {
        private Hashtable exits;
        //private Hashtable characters;
        //private Hashtable items;

        private Inventory items;
        private readonly NonPlayerCharacterCollection characterList;
        private readonly ExitCollection exitCollection;
        private String description;
        private String label;

        public Location()
        {
            exitCollection = new ExitCollection();
            characterList = new NonPlayerCharacterCollection();
            items = new Inventory();
        }

        public Location(String description, String label):this()
        {
            Description= description;
            Label = label;
            exits = new Hashtable();
        }
        
        //add NPC 
        public void AddNonPlayerCharacter(NonPlayerCharacter theNPC)
        {
            characterList.Add(theNPC.Name, theNPC);
        }
        //

        //remove NPC
        public bool RemoveNonPlayerCharacter(string name)
        {
            return characterList.Remove(name);
        }
        //

        //get Inventory
        public Inventory GetInventory()
        {
            return items;
        }
        //

        
        //exit Collection
        public ExitCollection GetExitCollection()
        {
            return exitCollection;
        }


        public Boolean AddExit(String exitLabel, Exit theExit)
        {
            if (exits.ContainsKey(exitLabel))
                return false;
            exits.Add(exitLabel, theExit);
            return true;
        }

        public Exit GetExit(String exitLabel)
        {
            return (Exit)exits[exitLabel];
        }

       


        public String AvailableExits()
        {
            StringBuilder returnMsg = new StringBuilder();
            foreach (string label in this.exits.Keys)
            {
                returnMsg.Append("[" + label + "] ");
            }
            return returnMsg.ToString();
        }

        public override string ToString()
        {
            return "**********\n" + this.Label + "\n**********\n"
                + "Exits found :: " + AvailableExits() + "\n**********\n"
                +"\n"+characterList.ToString()
                +"\n************\nYou find yourself in "
                + this.Description + "\n**********\n";
        }

        public bool ContainsExit(String exitLabel)
        {
            return exits.Contains(exitLabel);
        }

    }

}
