using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazegame.Entity;

namespace Mazegame.Control
{
    public class SellCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {

            if (userInput.Arguments.Count == 0)
            {
                return new CommandResponse(thePlayer.Inventory.ToString() + "\r\nIf you want to sell items you need to tell me item name");
            }

            Inventory locationInventory = thePlayer.CurrentLocation.GetInventory();
            String itemLabel = (String)userInput.Arguments[0];
            Item item = thePlayer.Inventory.RemoveItem(itemLabel);

            if (item != null)
            {
                locationInventory.AddItem(item);
                int itemWorth = item.GetWorth();
                thePlayer.Inventory.AddMoney(itemWorth);
                locationInventory.RemoveMoney(itemWorth);
                return new CommandResponse("You already bought this item");
            }

            return new CommandResponse("You haven't sell anything.");
        }
    }
}
