using UnityEngine;

public class Hacker : MonoBehaviour
{

    
    string[] level1passwords = { "candy", "counter", "food", "money", "sales" };
    string[] level2passwords = { "credit-card", "withdraw", "currency", "machine", "deposit" };
    string[] level3passwords = { "customer", "statement", "interest", "machinery", "safety deposit" };

    
    int level;

    enum Screen { MainMenu, Password, Win }
    Screen currentScreen = Screen.MainMenu;
    string password;


    
    void Start()
    {

        ShowMainMenu();
    }


    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome, User! Where would you like to hack today?\n");
        Terminal.WriteLine("Press 1 to select Local Shop (Easy)\n");
        Terminal.WriteLine("Press 2 to select ATM (Medium)\n");
        Terminal.WriteLine("Press 3 to select The Bank (Hard)\n");
        Terminal.WriteLine("Please enter your selection:\n");


    }


    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();


        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    void RunMainMenu(string input)
    {
        bool isvalidlevelnumber = (input == "1" || input == "2" || input == "3");
        if (isvalidlevelnumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }



        else if (input == "Joel")
        {
            Terminal.WriteLine("Joel is the epicest gamer that ever\n gamed.");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level.");
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Enter your password. Hint: " + password.Anagram());
        Terminal.WriteLine("\n \n \n \n \n \n \n \n Type 'menu' to select another level.");
    
    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                int randomlevel1 = Random.Range(0, level1passwords.Length);
                password = level1passwords[randomlevel1];
                break;
            case 2:
                int randomlevel2 = Random.Range(0, level2passwords.Length);
                password = level2passwords[randomlevel2];
                break;
            case 3:
                int randomlevel3 = Random.Range(0, level3passwords.Length);
                password = level3passwords[randomlevel3];
                break;
            default:
                Debug.LogError("Level Number Invalid");
                break;

        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();

    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine(@"



                 __                 
 /\  _ _ _ _ _  / _  _ _  _ |_ _ _| 
/--\(_(_(-_)_)  \__)| (_|| )|_(-(_| 
                                    
............

Wiring Money from customer accounts....
Transaction complete. Type 'menu' to   return to the Main Menu.");
                break;
            case 2:
                Terminal.WriteLine(@"
                 __                 
 /\  _ _ _ _ _  / _  _ _  _ |_ _ _| 
/--\(_(_(-_)_)  \__)| (_|| )|_(-(_| 
                                    
............

Replicating Card information.......
Replication complete. Type 'menu' to return to the Main Menu.");
                break;
            case 3:
                Terminal.WriteLine(@"
                 __                 
 /\  _ _ _ _ _  / _  _ _  _ |_ _ _| 
/--\(_(_(-_)_)  \__)| (_|| )|_(-(_| 
                                    
...........
Transferring Money from Online Banking services.....
Transaction complete. Type 'menu' to return to the Main Menu.");
                break;

            
                





        }
    }
}
