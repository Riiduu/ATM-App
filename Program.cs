namespace ATMApp;

class Program
{
    static void Main(string[] args)
    {
        CredentialCheck creds = new CredentialCheck();
        
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
        Console.Write("action >");
        int action = Int32.Parse(Console.ReadLine());

        creds.usernames.Add("admin");
        creds.passwords.Add("test");
        creds.usernames.Add("admin1");
        creds.passwords.Add("test1");
        creds.usernames.Add("admin2");
        creds.passwords.Add("test2");

        if (action == 1)
            creds.LoginFunc();
        else
            creds.RegisterFunc();
    }
}