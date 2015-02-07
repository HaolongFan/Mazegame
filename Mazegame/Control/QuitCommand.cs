using Mazegame.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazegame.Control
{
    public class QuitCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput, Player thePlayer)
        {
            return new CommandResponse("Thanks for playing -- Goodbye", true);
        }
    }
}
