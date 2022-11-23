namespace ConsoleATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOB-ATM Service");
            Console.WriteLine("**************************");

            RegistrationClass registrationClass = new();
            registrationClass.RegisterUser();
            //Console.Clear();

            Console.WriteLine("Enter your Atm Pin");
            int enteredPin = Convert.ToInt32(Console.ReadLine());

            registrationClass.LoginWithPin(enteredPin);
            
            Console.ReadLine();
        }
    }
}
