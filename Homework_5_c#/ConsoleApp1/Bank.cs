namespace ConsoleApp1;

internal class Bank
{
    public Client Clients { get; set; }

    public Bank()
    {

    }

    public Bank(Client clients)
    {
        this.Clients = clients;
    }
    public void showCard()
    {

        Console.Write("Bank Name: ");
        Console.WriteLine(Clients.bankAccount.Bankname);

        Console.Write("Bank Fullname: ");
        Console.WriteLine(Clients.bankAccount.Fullname);

        Console.Write("Client ID: ");
        Console.WriteLine(Clients.Id);

        Console.Write("Client Name: ");
        Console.WriteLine(Clients.Name);

        Console.Write("Client Surname: ");
        Console.WriteLine(Clients.Surname);

        Console.Write("Client Age: ");
        Console.WriteLine(Clients.Age);

        Console.Write("Client PAN: ");
        Console.WriteLine(Clients.bankAccount.PAN);

        Console.Write("Client PIN: ");
        Console.WriteLine(Clients.bankAccount.PIN);

        Console.Write("Client CVC: ");
        Console.WriteLine(Clients.bankAccount.CVC);

        Console.Write("Client Salary: ");
        Console.WriteLine(Clients.Salary);

        Console.Write("Balance: ");
        Console.WriteLine(Clients.bankAccount.Balance);

        Console.Write("Expire Date: ");
        Console.WriteLine(Clients.bankAccount.ExpireDate);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("<---------------------------------------------->");
        Console.WriteLine();
        Console.WriteLine();

    }
}