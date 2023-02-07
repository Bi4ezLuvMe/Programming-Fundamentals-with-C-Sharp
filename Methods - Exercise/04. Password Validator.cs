namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool IsValid = true;
            if (!IsLong(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                IsValid = false;
            }
            if (!IsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                IsValid = false;
            }

            if (!Is2Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                IsValid = false;
            }
            if (IsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsLong(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsOnlyLettersAndDigits(string password)
        {
            bool isValid = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    
                }
                else if (password[i] >= 65 && password[i] <= 90)
                {
                    
                }
                else if (password[i] >= 97 && password[i] <= 122)
                {
                    
                }
                else
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                return true;
            }

            return false;

        }
        static bool Is2Digits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}