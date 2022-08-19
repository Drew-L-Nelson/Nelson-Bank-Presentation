class Program
{
    static void Main()
    {
        // display title
        System.Console.WriteLine("*************** Nelson Bank ***************");
        System.Console.WriteLine("::Login Page::");

        // declare variables to store username and password
        string userName = null, password = null;

        // read userName from keyboard
        System.Console.Write("Username:");
        userName = System.Console.ReadLine(); // ReadLine will read the value from the keyboard and assign it to the userName variable

        // read password from keyboard only if username is entered
        if (userName != "")
        {
            System.Console.Write("Password:");
            password = System.Console.ReadLine();
        }

        // check username and passwork
        if (userName == "system" && password == "manager")
        {
            System.Console.WriteLine("TO DO: Main menu here");
        }

        //about to exit
        System.Console.Write("Thank you! Please visit us again.");
        System.Console.ReadKey();
    }
}
