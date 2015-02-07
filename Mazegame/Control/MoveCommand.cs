using Mazegame.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazegame.Control
{
    public class MoveCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput, Player thePlayer)
        {
            if (userInput.Arguments.Count == 0)
            {
                return new CommandResponse("If you want to move you need to tell me where");
            }

            String exitLabel = (String)userInput.Arguments[0];
            Exit desiredExit = thePlayer.CurrentLocation.GetExit(exitLabel);
            if (desiredExit == null)
            {
                return new CommandResponse("There is no exit there.. Trying moving someplace moveable!!");
            }

            thePlayer.CurrentLocation = desiredExit.Destination;
            return new CommandResponse("You successfully move " + exitLabel + " and find yourself somewhere else\n\n" + thePlayer.CurrentLocation.ToString());
        }
    }
}
