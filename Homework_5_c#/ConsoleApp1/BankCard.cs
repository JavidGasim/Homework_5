namespace ConsoleApp1;

internal class BankCard
{
    public string Bankname { get; set; }
    public string Fullname { get; set; }
    public string PAN { get; set; }
    public string PIN { get; set; }
    public string CVC { get; set; }
    public DateOnly ExpireDate { get; set; }
    public int Balance { get; set; }

    public BankCard()
    {
        
    }

    public BankCard(string Bankname, string Fullname, string PAN, string PIN, string CVC, DateOnly ExpireDate, int Balance)
    {
        this.Bankname = Bankname;
        this.Fullname = Fullname;
        this.PAN = PAN;
        this.PIN = PIN;
        this.CVC = CVC;
        this.ExpireDate = ExpireDate;
        this.Balance = Balance;
    }
}