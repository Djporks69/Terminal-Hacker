using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Hacker : MonoBehaviour {

    //game state
    int level;

    enum Screen { MainMenu, Password, Win }
    Screen currentScreen = Screen.MainMenu;
    string password;


    // Start is called before the first frame update
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
        else if (currentScreen == Screen.MainMenu)
        {
            CheckPassword(input);
        }

    }

    void RunMainMenu(string input)
    {
      
        if (input == "1")
        {
            level = 1;
            password = "candy";
            StartGame();
            


        }

        else if (input == "2")
        {
            level = 2;
            password = "withdraw";
            StartGame();
            
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

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Well done! You did it");
        }
        else
        {
            Terminal.WriteLine("Incorrect Password");
        }
}
}
