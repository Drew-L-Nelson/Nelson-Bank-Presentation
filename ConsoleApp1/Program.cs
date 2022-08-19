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
            // declare variable to store menu choice
            int mainMenuChoice = -1;
            do
            {
                //show main menu
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                //accept menu choice from keyboard
                System.Console.Write("Enter Choice:");
                mainMenuChoice = int.Parse(System.Console.ReadLine()); // int.Parse() is one way to convert strings into numerical type

                //switch-case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu();
                        break;
                    case 2: AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }

        //about to exit
        System.Console.Write("Thank you! Please visit us again.");
        System.Console.ReadKey();
    }


    static void CustomersMenu()
    {
        // variable to store customers menu choice
        int customersMenuChoice = -1;

        do
        {
            // print customers menu
            System.Console.WriteLine("\n:::Customers Menu:::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter Choice:");
            customersMenuChoice = System.Convert.ToInt32(System.Console.ReadLine()); // ToIne32() is another way to convert strings into numerical types
        } while (customersMenuChoice != 0); 
    }


    static void AccountsMenu()
    {
        // variable to store accounts menu choice
        int accountsMenuChoice = -1;

        do
        {
            // print accounts menu
            System.Console.WriteLine("\n:::Accounts Menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Account");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter Choice:");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine()); // ToIne32() is another way to convert strings into numerical types
        } while (accountsMenuChoice != 0);
    }
}
