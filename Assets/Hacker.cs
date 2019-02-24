﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Hacker : MonoBehaviour {

    //Game Configuration Data
    string[] level1passwords = { "candy", "counter", "food", "money", "sales" };
    string[] level2passwords = { "credit-card", "withdraw", "currency", "machine", "deposit" };
    string[] level3passwords = { "customer", "statement", "interest", "machinery", "safety deposit" };

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
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                password = level1passwords[0];
                break;
            case 2:
                password = level2passwords[0];
                break;
            case 3:
                password = level3passwords[0];
                break;
            default:
                Debug.LogError("Level Number Invalid");
                break;
          
        }
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password:");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Correct Password, Access Granted.");
        }
        else
        {
            Terminal.WriteLine("Incorrect Password");
        }
}
}