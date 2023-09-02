namespace ConsoleApp1;

internal class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public BankCard bankAccount { get; set; }

    public Client()
    {

    }

    public Client(Guid Id, string Name, string Surname, int Age, double Salary, BankCard bankAccount)
    {
        this.Id = Id;
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.Salary = Salary;
        this.bankAccount = bankAccount;
    }
}