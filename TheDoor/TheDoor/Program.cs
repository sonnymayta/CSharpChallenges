namespace TheDoor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Create a new door. Please, enter de codepass: ");
            int passCode = Convert.ToInt32(Console.ReadLine());
            Door door = new Door(passCode);
            Console.WriteLine("The door is created. It is locked by default.");
            bool isRunning = true;
            do
            {
                Console.WriteLine("Please, enter the command: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "open":
                        door.Open();
                        break;
                    case "close":
                        door.Close();
                        break;
                    case "lock":
                        door.Lock();
                        break;
                    case "unlock":
                        Console.Write("Please, enter the codepass: ");
                        int unlockCode = Convert.ToInt32(Console.ReadLine());
                        door.Unlocked(unlockCode);
                        break;
                    case "changepasscode":
                        Console.Write("Please, enter the old codepass: ");
                        int oldPassCode = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please, enter the new codepass: ");
                        int newPassCode = Convert.ToInt32(Console.ReadLine());
                        door.ChangePassCode(oldPassCode, newPassCode);
                        break;
                    case "exit":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            } while (isRunning);
        }
    }

    internal class Door
    {
        private int _passCode;

        internal DoorState State { get; set; }

        internal Door(int passCode)
        {
            State = DoorState.Locked;
            _passCode = passCode;
        }

        internal void Open()
        {
            if (State == DoorState.Locked)
            {
                Console.WriteLine("The door is locked.");
                return;
            }
            State = DoorState.Open;
            Console.WriteLine("The door is now open.");
        }

        internal void Close()
        {
            if (State == DoorState.Locked)
            {
                Console.WriteLine("The door is locked.");
                return;
            }
            State = DoorState.Closed;
            Console.WriteLine("The door is now closed.");
        }

        internal void Lock()
        {
            if (State == DoorState.Open)
            {
                Console.WriteLine("You cannot lock the door while it is open.");
                return;
            }
            State = DoorState.Locked;
            Console.WriteLine("The door is now locked.");
        }

        internal void Unlocked(int passCode)
        {
            if (passCode == _passCode)
            {
                State = DoorState.Closed;
                Console.WriteLine("The door is now unlocked.");
            }
            else
            {
                Console.WriteLine("Incorrect passcode.");
            }
        }

        internal void ChangePassCode(int oldPassCode, int newPassCode)
        {
            if (oldPassCode == _passCode)
            {
                _passCode = newPassCode;
                Console.WriteLine("The passcode has been changed.");
            }
            else
            {
                Console.WriteLine("Incorrect old passcode.");
            }
        }
    }

    enum DoorState
    {
        undefined,
        Open,
        Closed,
        Locked
    }
}
