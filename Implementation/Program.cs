namespace Implementation
{
    public class Program
    {
        public class Encapsulate
        {
            private int _balance;
            public Encapsulate()
            {
                _balance = 0;
            }
            public int GetBalance()
            {
                if (_balance < 0)
                {
                    return 0;
                }
                return _balance;
            }
            public void Deposit(int amount)
            {
                if (amount >= 0)
                {
                    _balance += amount;
                    Console.WriteLine($"Amount Deposited: {amount}");
                    Console.WriteLine($"New Balance {_balance}");
                }
                else
                {
                    Console.WriteLine("Amount should be greater than 0");
                }
            }
            public void WithDraw(int amount)
            {
                if (amount <= _balance)
                {
                    _balance -= amount;
                    Console.WriteLine($"Amount Withdrawn :{amount}");
                    Console.WriteLine($"New Balance : {_balance}");
                }
                else
                {
                    Console.WriteLine("Your balance amount is less than the entered amount");
                }
            }
        }

        public static void Main(string[] strings)
        {
            Encapsulate en = new Encapsulate();
            while (true)
            {
                Console.WriteLine("\n------ MENU ------");
                Console.WriteLine("1. Get Balance");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Exit");
                Console.Write("Kindly select any option to proceed: ");
                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    //continue;
                }
                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Your Balance is :{en.GetBalance()} ");
                        break;
                    case 2:
                        Console.WriteLine("Kindly provide the amount to withdraw : ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        en.WithDraw(withdraw);
                        break;
                    case 3:
                        Console.WriteLine("Provide the amount you want to deposit : ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        en.Deposit(deposit);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our services");
                        return;
                    default:
                        Console.WriteLine("Please select proper option");
                        break;
                }

            }

        }
    }
}