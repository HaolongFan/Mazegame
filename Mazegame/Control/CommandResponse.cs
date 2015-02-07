using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazegame.Control
{
    public class CommandResponse
    {
        private bool finishedGame;
        private string message;

        public CommandResponse(string message)
        {
            Message = message;
            FinishedGame = false;
        }

        public CommandResponse(string message, bool quitFlag)
        {
            Message = message;
            FinishedGame = quitFlag;
        }

        public bool FinishedGame
        {
            get { return finishedGame; }
            set { finishedGame = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}

