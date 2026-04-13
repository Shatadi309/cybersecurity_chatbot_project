using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace cybersecurity_chatbot_project
{//sart of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //creating an instance for the bot_greeting class with constructor
            new bot_greeting() { };

            //creating an instance for the bot_logo class with a constructor
            new bot_logo() { };

            //creating an instance for the welcome_user class with object name greeting
            welcome_user greeting = new welcome_user();

            //calling the welcome method
            greeting.welcome();

            //calling the ask_userInput method
            greeting.ask_userInput();

            //creating an instance for the show_chats class with an object name collect_chats
            show_chats collect_chats = new show_chats();

            //calling the chats method
            collect_chats.chats();

            //creating an instance for the search_and_chat class
            search_and_chat begin_chat = new search_and_chat();

            //calling the method begin_chat with a parameter
            string username = "VANTA";
            begin_chat.chatbot(username);



        }//end of main method
    }//end of class
}//end of namespace
