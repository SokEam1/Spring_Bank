// See https://aka.ms/new-console-template for more information
using Spring_Bank;

//Account myAccount = new Account(1111, 0, "checking");
//Account myAccount2 = new Account(2222, 0, "savings");
//Dictionary<string, Account> myMonies = new Dictionary<string, Account>();
Account account3 = new Account(0, 0, "");
//myMonies.Add(myAccount.AccountType, myAccount);
//myMonies.Add(myAccount.AccountType, myAccount2);
Dictionary<string, Account> myDictionary = new Dictionary<string, Account>();
Bank myBank2 = new Bank(myDictionary);
int acctNum = 3333;
//Bank myBank = new Bank(myMonies); 
bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("Welcome to CSHARPBank!! Choose an option below\n");
    Console.WriteLine("1. Open a new account");
    Console.WriteLine("2. Checkyour account balance");
    Console.WriteLine("3. Make a withdrawl");
    Console.WriteLine("4. Make a deposit");
    Console.WriteLine("5. Close your account");
    Console.WriteLine("6. Display account information");
    Console.WriteLine("E. Exit");

    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("What kind of account would you like to open");
            string choice = Console.ReadLine();
            if(choice == "checking")
            {
                Account acct = new Account(acctNum, 0, "");
                acct.AccountType = "checking";
                myBank2.openNewAccount(acct);
                Console.WriteLine("You have opened a checking account");

            }
            else if (choice == "savings")
            {
                Account acct2 = new Account(acctNum, 0, "");
                acct2.AccountType = "savings";
                myBank2.openNewAccount(acct2);
                Console.WriteLine("You have opened a savings account");
            }
            acctNum++;
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            //adding acct3 to our empty dictionary
            myDictionary.Add(account3.AccountType, account3);
            myBank2 = new Bank(myDictionary);
            break;
        case "2":
            Console.WriteLine("Which account would you like to check? Checking? or savings?");
            string userInput = Console.ReadLine();
            myBank2.getAccount(userInput).CheckAccount();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("Which account would you like to withdrawl from? checking? or savings?");
            userInput = Console.ReadLine();
            Console.WriteLine("How much money would you like to withdrawl?");
            double money = Convert.ToDouble(Console.ReadLine());
            myBank2.getAccount(userInput).Withdrawl(money);
            Console.WriteLine("You withdrew $" + money + "dollars");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine("Which account would you like to deposit to? checking? or savings?");
            userInput = Console.ReadLine();
            Console.WriteLine("How much money would you like to deposit?");
            money = Convert.ToDouble(Console.ReadLine());
            myBank2.getAccount(userInput).Deposit(money);
            Console.WriteLine("You deposited  $" + money + " dollars");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            break;
        case "5":
            Console.WriteLine("Which account would you like to close? checking? or savings?");
            userInput = Console.ReadLine();
            myBank2.closeAccount(myBank2.getAccount(userInput));
            Console.WriteLine("You have closed your " + userInput + "Account");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            break;
        case "6":
            Console.WriteLine("Savings: " + myBank2.getAccount("savings").AccountBalance);
            Console.WriteLine("Checking: " + myBank2.getAccount("checking").AccountBalance);
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            break;
        case "E":
            isRunning = false;
            break;
        default:
            break;
    }
}

