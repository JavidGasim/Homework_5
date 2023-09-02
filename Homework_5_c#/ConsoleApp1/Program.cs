using ConsoleApp1;

Random random = new Random();

DateOnly dateTime1 = new DateOnly(2025, 6, 18);
DateOnly dateTime2 = new DateOnly(2024, 3, 11);
DateOnly dateTime3 = new DateOnly(2025, 9, 27);
DateOnly dateTime4 = new DateOnly(2025, 12, 18);
DateOnly dateTime5 = new DateOnly(2025, 9, 20);

int cvc1_ = random.Next(100, 999);
string cvc1 = Convert.ToString(cvc1_);
int balance1 = random.Next(0, 2000);
BankCard bankCard1 = new BankCard("Kapital", "Kapital Bank", "4169 7388 3206 4780", "0920", cvc1, dateTime1, balance1);

int cvc2_ = random.Next(100, 999);
string cvc2 = Convert.ToString(cvc2_);
int balance2 = random.Next(0, 2000);
BankCard bankCard2 = new BankCard("Access", "Access Bank", "5345 4934 3979 7851", "4354", cvc2, dateTime2, balance2);

int cvc3_ = random.Next(100, 999);
string cvc3 = Convert.ToString(cvc3_);
int balance3 = random.Next(0, 2000);
BankCard bankCard3 = new BankCard("ATB", "Azer-Turk Bank", "1534 7356 2462 0493", "3768", cvc3, dateTime3, balance3);

int cvc4_ = random.Next(100, 999);
string cvc4 = Convert.ToString(cvc4_);
int balance4 = random.Next(0, 2000);
BankCard bankCard4 = new BankCard("ABB", "Azerbaycan Beynelxalq Banki", "1224 1442 4678 5472", "4984", cvc4, dateTime4, balance4);

int cvc5_ = random.Next(100, 999);
string cvc5 = Convert.ToString(cvc5_);
int balance5 = random.Next(0, 2000);
BankCard bankCard5 = new BankCard("Kapital", "Kapital Bank", "4169 7388 3547 3570", "3861", cvc5, dateTime5, balance5);

Client client1 = new Client(Guid.NewGuid(), "Cavid", "Gasimov", 19, 98, bankCard1);
Client client2 = new Client(Guid.NewGuid(), "Ferid", "Fuadov", 43, 560, bankCard2);
Client client3 = new Client(Guid.NewGuid(), "Suleyman", "Karimli", 28, 865, bankCard3);
Client client4 = new Client(Guid.NewGuid(), "Mehman", "Salimli", 32, 1950, bankCard4);
Client client5 = new Client(Guid.NewGuid(), "Rustam", "Gafarov", 23, 945, bankCard5);

while (true)
{
    Console.Write("ENTER PIN: ");
    string enter_pin = Console.ReadLine();

    if ((enter_pin == "0920") || (enter_pin == "4354") || (enter_pin == "3768") || (enter_pin == "4984") || (enter_pin == "3861"))
    {
        Console.WriteLine("1)All Information");
        Console.WriteLine("2)Cash Out");
        Console.WriteLine("3)Card to Card");
        Console.WriteLine("4)Exit");

        Console.Write("CHOOSE: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            if (enter_pin == "0920")
            {
                Bank bank = new Bank(client1);

                bank.showCard();
            }

            else if (enter_pin == "4354")
            {
                Bank bank = new Bank(client2);

                bank.showCard();
            }

            else if (enter_pin == "3768")
            {
                Bank bank = new Bank(client3);

                bank.showCard();
            }

            else if (enter_pin == "4984")
            {
                Bank bank = new Bank(client4);

                bank.showCard();
            }

            else if (enter_pin == "3861")
            {
                Bank bank = new Bank(client5);

                bank.showCard();
            }

        }

        else if (choice == "2")
        {
            Console.WriteLine("1)10 AZN");
            Console.WriteLine("2)20 AZN");
            Console.WriteLine("3)50 AZN");
            Console.WriteLine("4)100 AZN");
            Console.WriteLine("5)OTHER");

            Console.Write("CHOOSE: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                if (enter_pin == "0920")
                {
                    if (client1.bankAccount.Balance>=10)
                    {
                        client1.bankAccount.Balance -= 10;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4354")
                {
                    if (client2.bankAccount.Balance >= 10)
                    {
                        client2.bankAccount.Balance -= 10;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    if (client3.bankAccount.Balance >= 10)
                    {
                        client3.bankAccount.Balance -= 10;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    if (client4.bankAccount.Balance >= 10)
                    {
                        client4.bankAccount.Balance -= 10;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    if (client5.bankAccount.Balance >= 10)
                    {
                        client5.bankAccount.Balance -= 10;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

            }

            else if (secim == "2")
            {
                if (enter_pin == "0920")
                {
                    if (client1.bankAccount.Balance >= 20)
                    {
                        client1.bankAccount.Balance -= 20;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4354")
                {
                    if (client2.bankAccount.Balance >= 20)
                    {
                        client2.bankAccount.Balance -= 20;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    if (client3.bankAccount.Balance >= 20)
                    {
                        client3.bankAccount.Balance -= 20;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    if (client4.bankAccount.Balance >= 20)
                    {
                        client4.bankAccount.Balance -= 20;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    if (client5.bankAccount.Balance >= 20)
                    {
                        client5.bankAccount.Balance -= 20;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

            }

            else if (secim == "3")
            {
                if (enter_pin == "0920")
                {
                    if (client1.bankAccount.Balance >= 50)
                    {
                        client1.bankAccount.Balance -= 50;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4354")
                {
                    if (client2.bankAccount.Balance >= 50)
                    {
                        client2.bankAccount.Balance -= 50;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    if (client3.bankAccount.Balance >= 50)
                    {
                        client3.bankAccount.Balance -= 50;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    if (client4.bankAccount.Balance >= 50)
                    {
                        client4.bankAccount.Balance -= 50;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    if (client5.bankAccount.Balance >= 50)
                    {
                        client5.bankAccount.Balance -= 50;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }
            }

            else if (secim == "4")
            {
                if (enter_pin == "0920")
                {
                    if (client1.bankAccount.Balance >= 100)
                    {
                        client1.bankAccount.Balance -= 100;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4354")
                {
                    if (client2.bankAccount.Balance >= 100)
                    {
                        client2.bankAccount.Balance -= 100;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    if (client3.bankAccount.Balance >= 100)
                    {
                        client3.bankAccount.Balance -= 100;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    if (client4.bankAccount.Balance >= 100)
                    {
                        client4.bankAccount.Balance -= 100;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    if (client5.bankAccount.Balance >= 100)
                    {
                        client5.bankAccount.Balance -= 100;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

            }

            else if (secim == "5")
            {
                Console.Write("ENTER MONEY: ");
                string mebleg_ = Console.ReadLine();
                int mebleg = Convert.ToInt32(mebleg_);

                if (enter_pin == "0920")
                {
                    if (client1.bankAccount.Balance >= mebleg)
                    {
                        client1.bankAccount.Balance -= mebleg;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4354")
                {
                    if (client2.bankAccount.Balance >= mebleg)
                    {
                        client2.bankAccount.Balance -= mebleg;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    if (client3.bankAccount.Balance >= mebleg)
                    {
                        client3.bankAccount.Balance -= mebleg;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    if (client4.bankAccount.Balance >= mebleg)
                    {
                        client4.bankAccount.Balance -= mebleg;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    if (client5.bankAccount.Balance >= mebleg)
                    {
                        client5.bankAccount.Balance -= mebleg;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

            }

            else
            {
                Console.WriteLine("WRONG");
            }
        }

        else if (choice=="3")
        {
            Console.Write("ENTER PIN: ");
            string _pin = Console.ReadLine();

            if (_pin=="0920")
            {
                if (enter_pin=="0920")
                {
                    Console.WriteLine("You can't send money from your card to your card");
                }

                else if (enter_pin=="4354")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client2.bankAccount.Balance >= money)
                    {
                        client2.bankAccount.Balance -= money;
                        client1.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client3.bankAccount.Balance >= money)
                    {
                        client3.bankAccount.Balance -= money;
                        client1.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client4.bankAccount.Balance >= money)
                    {
                        client4.bankAccount.Balance -= money;
                        client1.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client5.bankAccount.Balance >= money)
                    {
                        client5.bankAccount.Balance -= money;
                        client1.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }
            }

            else if (_pin == "4354")
            {
                if (enter_pin == "4354")
                {
                    Console.WriteLine("You can't send money from your card to your card");
                }

                else if (enter_pin == "0920")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client1.bankAccount.Balance >= money)
                    {
                        client1.bankAccount.Balance -= money;
                        client2.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client3.bankAccount.Balance >= money)
                    {
                        client3.bankAccount.Balance -= money;
                        client2.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client4.bankAccount.Balance >= money)
                    {
                        client4.bankAccount.Balance -= money;
                        client2.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client5.bankAccount.Balance >= money)
                    {
                        client5.bankAccount.Balance -= money;
                        client2.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }
            }

            else if (_pin == "3768")
            {
                if (enter_pin == "3768")
                {
                    Console.WriteLine("You can't send money from your card to your card");
                }

                else if (enter_pin == "4354")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client2.bankAccount.Balance >= money)
                    {
                        client2.bankAccount.Balance -= money;
                        client3.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "0920")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client1.bankAccount.Balance >= money)
                    {
                        client1.bankAccount.Balance -= money;
                        client3.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client4.bankAccount.Balance >= money)
                    {
                        client4.bankAccount.Balance -= money;
                        client3.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client5.bankAccount.Balance >= money)
                    {
                        client5.bankAccount.Balance -= money;
                        client3.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }
            }

            else if (_pin == "4984")
            {
                if (enter_pin == "4984")
                {
                    Console.WriteLine("You can't send money from your card to your card");
                }

                else if (enter_pin == "4354")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client2.bankAccount.Balance >= money)
                    {
                        client2.bankAccount.Balance -= money;
                        client4.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client3.bankAccount.Balance >= money)
                    {
                        client3.bankAccount.Balance -= money;
                        client4.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "0920")
                {
                    Console.WriteLine("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client1.bankAccount.Balance >= money)
                    {
                        client1.bankAccount.Balance -= money;
                        client4.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client5.bankAccount.Balance >= money)
                    {
                        client5.bankAccount.Balance -= money;
                        client4.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }
            }

            else if (_pin == "3861")
            {
                if (enter_pin == "3861")
                {
                    Console.WriteLine("You can't send money from your card to your card");
                }

                else if (enter_pin == "4354")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client2.bankAccount.Balance >= money)
                    {
                        client2.bankAccount.Balance -= money;
                        client5.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3768")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client3.bankAccount.Balance >= money)
                    {
                        client3.bankAccount.Balance -= money;
                        client5.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "4984")
                {
                    Console.WriteLine("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client4.bankAccount.Balance >= money)
                    {
                        client4.bankAccount.Balance -= money;
                        client5.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }

                else if (enter_pin == "3861")
                {
                    Console.Write("ENTER MONEY: ");
                    string _money = Console.ReadLine();

                    int money = Convert.ToInt32(_money);

                    if (client1.bankAccount.Balance >= money)
                    {
                        client1.bankAccount.Balance -= money;
                        client5.bankAccount.Balance += money;
                    }

                    else
                    {
                        Console.WriteLine("NOT ENOUGH MONEY");
                    }
                }
            }

            else
            {
                Console.WriteLine("No Card Found for This PIN Code");
            }
        }

        else if (choice == "4")
        {
            break;
        }
    }

    else
    {
        Console.WriteLine("WRONG");
    }
}