namespace ATMApp;

public class CredentialCheck
{
    public List<String> usernames = new List<string>();
    public List<String> passwords = new List<string>();

    public void RegisterFunc()
    {
        
    }

    public void LoginFunc()
    {
        Console.WriteLine("Enter username");
        Console.Write("username: ");
        string username = Console.ReadLine();
        
        Console.WriteLine("Enter password");
        Console.Write("password: ");
        string password = Console.ReadLine();

        for (int i = 0; i < usernames.Count; i++)
        {
            if (username == usernames[i] && password == passwords[i])
                Console.WriteLine("Login Successful");
            if (i > 0)
                continue;
            
            Console.WriteLine("Checking...");
        }
    }
}