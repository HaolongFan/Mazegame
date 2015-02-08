using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazegame.Entity;
using Mazegame.Entity.Utility;

namespace Mazegame.Control
{
    public class AttackCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            NonPlayerCharacterCollection nonplayers = thePlayer.CurrentLocation.GetNonPlayerCharacter();

            if (userInput.Arguments.Count == 0)
            {
                return new CommandResponse(nonplayers.ToString() + "\r\nIf you want to attack soemone you need to tell me the npc name");
            }

            String npcLabel = (String)userInput.Arguments[0];
            NonPlayerCharacter npc = new NonPlayerCharacter();

            if (nonplayers.TryGetValue(npcLabel, out npc))
            {
                //totally not able to understand the attack logic

                thePlayer.LifePoints -= (npc.Agility - thePlayer.Strength);
                thePlayer.Strength -= npc.Agility;
                npc.LifePoints -= thePlayer.Strength;

                return new CommandResponse("You already attacked thie npc");
            }

            return new CommandResponse("You haven't attack anyone.");
        }
    }
}
