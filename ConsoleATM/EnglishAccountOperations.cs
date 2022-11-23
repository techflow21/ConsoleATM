namespace ConsoleATM
{
    internal class EnglishAccountOperations
    {
        public static void EnglishAccountOperation(int operationOption)
        {
            Console.Clear();
            double accountBalance = 0;
            char cashType = '$';
            EnglishATMOperations englishAtmOperations = new();

            switch (operationOption)
            {
                case 1:
                    {
                        double transferedAmount;
                        Console.WriteLine("Enter the Amount to Transfer:");
                        transferedAmount = Convert.ToDouble(Console.ReadLine());
                        englishAtmOperations.transfer(transferedAmount, accountBalance, cashType);
                    }
                    break;

                case 2:
                    {
                        englishAtmOperations.checkBalance(accountBalance, cashType);
                    }
                    break;

                case 3:
                    {
                        double withdrawAmount;
                        Console.WriteLine("Enter the Amount to Withdraw:");
                        withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        englishAtmOperations.withdraw(withdrawAmount, accountBalance, cashType);
                    }
                    break;

                case 4:
                    {
                        englishAtmOperations.cancel();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("You entered invalid Operation Option");
                    }
                    break;
            }
        }
    }
}
