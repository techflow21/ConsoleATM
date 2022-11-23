namespace ConsoleATM
{
    public class RegistrationClass
    {
        private string ?customerName;
        private int atmPin;
        bool stillActive = true;
        public void RegisterUser()
        {
            Console.WriteLine("*** Register for an Account ***");
            Console.WriteLine("Enter your username: ");
            customerName = Console.ReadLine();
            
            Console.WriteLine("Enter your Pin: ");
            atmPin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hi {0}! Account Registration was Successful!", customerName);
        }

        public void LoginWithPin(int enteredPin)
        {
            string option = "N";
            while (stillActive || option == "Y")
            {
                try
                {
                    Console.WriteLine("Enter your Atm Pin");
                    enteredPin = Convert.ToInt32(Console.ReadLine());

                    if (enteredPin == atmPin)
                    {
                        Console.Clear();
                        LanguageClass.languageClass();

                        Console.WriteLine("Want to Carry Out another Operation, Enter (Y/N) ?");
                        option = Console.ReadLine().ToUpper();

                        if (option == "N")
                        {
                            stillActive = false;
                            Console.WriteLine("Thank you for using SOB-ATM Service");
                        }
                        else if (option == "Y")
                        {
                            stillActive = true;
                        }
                        else
                        {
                            stillActive = false;
                            Console.WriteLine("You entered an Invalid Character, Try Again!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered a Wrong Pin, Try Again");
                        LoginWithPin(enteredPin);
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong ATM Pin entered, Try again");
                    LoginWithPin(enteredPin);
                }
            }
        }
    }
}
