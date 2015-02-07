using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazegame.Entity.Utility;
using Mazegame.Entity;

namespace Mazegame.Entity
{
    public class FiniteInventory : Inventory
    {
        private double weightLimit;

        public FiniteInventory(int strength)
            : base()
        {
            SetStrength(strength);
        }

        public void SetStrength(int strength)
        {
            weightLimit = (double)WeightLimit.GetInstance().GetModifier(strength);
        }

        public double GetWeight()
        {
            double currentWeight = 0;
            foreach (Item theItem in this.itemList.Values)
            {
                currentWeight += theItem.GetWeight();
            }
            return currentWeight;
        }

        public virtual bool AddItem(Item theItem)
        {
            if (weightLimit > theItem.GetWeight() + GetWeight())
                return base.AddItem(theItem);
            return false;
        }
    }
}
