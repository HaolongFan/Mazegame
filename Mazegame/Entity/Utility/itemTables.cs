using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazegame.Entity.Utility
{
    public class itemTable
    {
        private static itemTable instance;

        private Dictionary<string, int> lookup = new Dictionary<string, int>();

        private itemTable(Dictionary<string, int> theTable)
        {
            lookup = theTable;
        }

        public static itemTable GetInstance()
        {
            if (instance == null)
                instance = new itemTable(new Dictionary<string, int>());
            return instance;
        }

        public void SetModifier(string item, int modifier)
        {
            lookup[item] = modifier;
        }

    }

    public class itemTableException : Exception
    {
        private string message;

        public itemTableException()
            : base()
        {
        }

        public itemTableException(string message)
        {
            this.message = message;
        }

        public string GetMessage()
        {
            return this.message;
        }
    }
}
