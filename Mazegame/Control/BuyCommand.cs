using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazegame.Entity;

namespace Mazegame.Control
{
    public class BuyCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            Inventory locationInventory = thePlayer.CurrentLocation.GetInventory();

            if (userInput.Arguments.Count == 0)
            {
                return new CommandResponse(locationInventory.ToString() + "\r\nIf you want to buy items you need to tell me item name");
            }

            String itemLabel = (String)userInput.Arguments[0];

            Item item = locationInventory.RemoveItem(itemLabel);

            if (item != null)
            {
                thePlayer.Inventory.AddItem(item);
                int itemWorth = item.GetWorth();
                thePlayer.Inventory.RemoveMoney(itemWorth);
                locationInventory.AddMoney(itemWorth);
                return new CommandResponse("You already bought this item");
            }

            return new CommandResponse("You haven't bought anything.");

        }
    }
}
