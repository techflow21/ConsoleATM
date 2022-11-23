namespace ConsoleATM
{
    // General Interface Methods common to all Languages.
    interface IOperationInterface
    {
        void transfer(double transferedAmount, double accountBalance, char cashType);
        void checkBalance(double accountBalance, char cashType);
        void withdraw(double withdrawAmount, double accountBalance, char cashType);
        void cancel();
    }

    // English Language ATM Operations
    class EnglishATMOperations : IOperationInterface
    {
        public void transfer(double transferedAmount, double accountBalance, char cashType)
        {
            if (transferedAmount > 0)
            {
                accountBalance += AccountBalanceClass.AccountBlcTransfer(transferedAmount);
                Console.WriteLine("Transfer was successfully!");
                Console.WriteLine("Your Account Balance is: {0}{1}", cashType, accountBalance);
            }
            else
            {
                Console.WriteLine("You entered an invalid Amount");
            }
        }

        public void checkBalance(double accountBalance, char cashType)
        {
            accountBalance = AccountBalanceClass.AccountBlcTransfer(accountBalance);
            Console.WriteLine("Your Account Balance is: {0}{1}", cashType, accountBalance);
        }

        public void withdraw(double withdrawAmount, double accountBalance, char cashType)
        {
            double accountBalanceW = AccountBalanceClass.AccountBlcTransfer(accountBalance);
            if (withdrawAmount >= 10 && accountBalanceW >= withdrawAmount)
            {
                accountBalance = AccountBalanceClass.AccountBlcWithdraw(withdrawAmount);
                Console.WriteLine("{0}{1} withdrawal was successfully!", cashType, withdrawAmount);
                Console.WriteLine("Your Account Balance is: {0}{1}", cashType, accountBalance);
            }
            else if (withdrawAmount < 10)
            {
                Console.WriteLine("You can't withdraw less than {0}10", cashType);
            }
            else if (withdrawAmount > accountBalance)
            {
                Console.WriteLine("Insufficient Account Balance");
            }
            else
            {
                Console.WriteLine("Your entry is invalid");
            }
        }

        public void cancel()
        {
            Console.WriteLine("Operation Cancelled");
        }
    }

    // Pidgin Language ATM Operations
    class PidginATMOperations : IOperationInterface
    {
        public void transfer(double transferedAmount, double accountBalance, char cashType)
        {
            if (transferedAmount > 0)
            {
                accountBalance += AccountBalanceClass.AccountBlcTransfer(transferedAmount);
                Console.WriteLine("Moni wey you transfa go wella!");
                Console.WriteLine("Your Moni wey remain na: {0}{1}", cashType, accountBalance);
            }
            else
            {
                Console.WriteLine("Wetin you enta no make make sense");
            }
        }

        public void checkBalance(double accountBalance, char cashType)
        {
            accountBalance = AccountBalanceClass.AccountBlcTransfer(accountBalance);
            Console.WriteLine("Your Moni wey remain na: {0}{1}", cashType, accountBalance);
        }

        public void withdraw(double withdrawAmount, double accountBalance, char cashType)
        {
            double accountBalanceW = AccountBalanceClass.AccountBlcTransfer(accountBalance);
            if (withdrawAmount >= 10 && accountBalanceW >= withdrawAmount)
            {
                accountBalance = AccountBalanceClass.AccountBlcWithdraw(withdrawAmount);
                Console.WriteLine("{0}{1} Moni commot from your akant well!",cashType, withdrawAmount);
                Console.WriteLine("Your Moni wey remain na: {0}{1}", cashType, accountBalance);
            }
            else if (withdrawAmount < 10)
            {
                Console.WriteLine("The Moni wey you wan commot no fit small pass {0}10", cashType);
            }
            else if (withdrawAmount > accountBalance)
            {
                Console.WriteLine("Your Moni wey remain too dey small");
            }
            else
            {
                Console.WriteLine("Wetin you enta no make sense");
            }
        }

        public void cancel()
        {
            Console.WriteLine("We no dey do anything again");
        }
    }

    // Yoruba Language ATM Operations
    class YorubaATMOperations : IOperationInterface
    {
        public void transfer(double transferedAmount, double accountBalance, char cashType)
        {
            if (transferedAmount > 0)
            {
                accountBalance += AccountBalanceClass.AccountBlcTransfer(transferedAmount);
                Console.WriteLine("Ifowo pamo yi yege!");
                Console.WriteLine("Eye Owo re toku je: {0}{1}", cashType, accountBalance);
            }
            else
            {
                Console.WriteLine("Eye owo ti o fe san si akanti re kere");
            }
        }

        public void checkBalance(double accountBalance, char cashType)
        {
            accountBalance = AccountBalanceClass.AccountBlcTransfer(accountBalance);
            Console.WriteLine("Eye Owo re toku je: {0}{1}", cashType, accountBalance);
        }

        public void withdraw(double withdrawAmount, double accountBalance, char cashType)
        {
            double accountBalanceW = AccountBalanceClass.AccountBlcTransfer(accountBalance);
            if (withdrawAmount >= 10 && accountBalanceW >= withdrawAmount)
            {
                accountBalance = AccountBalanceClass.AccountBlcWithdraw(withdrawAmount);
                Console.WriteLine("{0}{1} Owo ti ofe gba yege!",cashType, withdrawAmount);
                Console.WriteLine("Eye owo re toku je: {0}{1}", cashType, accountBalance);
            }
            else if (withdrawAmount < 10)
            {
                Console.WriteLine("Eye owo ti ofe gba ogbo do din ni {0}10", cashType);
            }
            else if (withdrawAmount > accountBalance)
            {
                Console.WriteLine("Eye Owo inu Akanti re oto nkan");
            }
            else
            {
                Console.WriteLine("Ounte re o yege");
            }
        }

        public void cancel()
        {
            Console.WriteLine("Adawo ise ATM duro");
        }
    }
}
