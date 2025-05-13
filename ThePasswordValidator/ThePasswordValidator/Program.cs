namespace ThePasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Enter a password:");
                string password = Console.ReadLine() ?? string.Empty;
                PasswordValidator passwordValidator = new PasswordValidator();
                passwordValidator.SetPassword(password);
            } while (repeat);
        }
    }

    internal class PasswordValidator
    {
        private string _password;

        internal PasswordValidator()
        {
            _password = string.Empty;
        }

        internal void SetPassword(string passworld)
        {
            if (passworld.Length >=6 && passworld.Length <=13)
            {
                bool upperCase = false;
                bool lowerCase = false;
                bool digit = false;
                bool t = false;
                bool umpersand = false;
                foreach (char letter in passworld)
                {
                    if (char.IsUpper(letter)) upperCase = true;
                    if (char.IsLower(letter)) lowerCase = true;
                    if (char.IsDigit(letter)) digit = true;
                    if (letter == 'T') t = true;
                    if (letter == '&') umpersand = true;
                }
                if (upperCase && lowerCase && digit && !t && !umpersand)
                {
                    _password = passworld;
                    Console.WriteLine("Password is valid.");
                }
                else
                {
                    Console.WriteLine("Password must contain at least one uppercase letter, one lowercase letter, one digit and not contain the characters T and &.");
                }
            }
            else
            {
                Console.WriteLine("Password must contain more than 6 characters and less than 13 characters.");
            }    
        }
    }
}
