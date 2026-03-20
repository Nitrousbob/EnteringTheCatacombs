namespace EnteringTheCatacombs
{
    internal class Door
    {
        //an open door can always be closed
        //a closed (but not locked) door can always be opened
        //A closed door can always be locked.
        //A locked door can be unlocked, but a numeric passcode
        //is needed, and the door will only unlock if the code
        //supplied matches the door's current passcode
        //When a door is created, it must be given an initial passcode
        //You should be able to change the passcode by supplying
        //the current code and a new one.  The passcode should only
        //change if the correct current code is given.

        public enum DoorState
        {
            Locked,
            Open,
            Closed
        }
        public int PassCode { get; set; }
        public string Name { get; set; }
        public DoorState State { get; set; }

        public Door(string name, DoorState state, int code)
        {
            Name = name;
            State = state;
            PassCode = code;
        }

        public void DoorMenu(Door door)
        {
            bool doorFun = true;
            while (doorFun)
            {
                char input;
                Console.WriteLine("You are at a door.");
                do Console.WriteLine("Would you like to [U]se the door, [C]hange the passcode?");
                while (!char.TryParse(Console.ReadLine(), out input));
                if (input == 'U' || input == 'u')
                {
                    door.DoorAction();
                }
                if (input == 'C' || input == 'c')
                {
                    ChangePasscode();
                }
            Console.ReadLine();  // pause between door actions
            }
        }

        public void DoorAction()
        {
            Console.WriteLine($"The Door is currently: {State}");

            if (State == DoorState.Locked) //door options are Unlock, need passcode
            {
                int code = 0;
                //prompt to enter PassCode, check if correct
                code = EnterPasskey(false);

                if (PassCode == code)
                {
                    //update DoorState if successful
                    Console.WriteLine("You have unlocked the door.");
                    State = DoorState.Closed;
                    return;
                }
                else
                {
                    //if wrong return, (no updating Doorstate)
                    Console.WriteLine("You have chosen poorly.");
                    return;
                }

            } 
            else if (State == DoorState.Closed)
            {
                //The door closed state is closed and unlocked
                char input;
                do Console.WriteLine("[L]ock or [O]pen the door?");
                while (!char.TryParse(Console.ReadLine(), out input));
                if (input == 'L' || input == 'l')
                {
                    Console.WriteLine("You have locked the door.");
                    State = DoorState.Locked;
                    return;
                }
                else if (input == 'O' || input == 'o')
                {
                    Console.WriteLine("You have opened the door.");
                    State = DoorState.Open;
                    return;
                }
                else
                {
                    Console.WriteLine("Please choose L or O.");
                }
            }

            else //if (State == DoorState.Open)
            {
                char input;
                do Console.WriteLine("[C]lose the door?");
                while (!char.TryParse(Console.ReadLine(), out input));
                if (input == 'C' || input == 'c')
                {
                    Console.WriteLine("You have closed the door.");
                    State = DoorState.Closed;
                }
                else
                {
                    Console.WriteLine("Please choose C.");
                }
            }
        }

        public void ChangePasscode()
        {
            int newCode = PassCode;
            Console.WriteLine("Enter the current pass code.");
            int oldCode = EnterPasskey(false);
            if (oldCode == PassCode)
            {
                PassCode = EnterPasskey(true);
            }
            else
            {
                Console.WriteLine("You have failed to give us a good code.");
            }
            
        }

        public int EnterPasskey(bool newKey)
        {
            int code;
            if (!newKey)
            {
                do Console.WriteLine("Unlock PassKey: ");
                while (!int.TryParse(Console.ReadLine(), out code));
                //return code;
            }
            else
            {
                do Console.WriteLine("Enter new PassKey: ");
                while (!int.TryParse(Console.ReadLine(), out code));
                //return code;
            }
            //validation of new passkey, hmm, may need string

            return code;
        }
    }
}
