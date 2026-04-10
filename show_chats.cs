using System;

namespace cybersecurity_chatbot_project
{//start of namespace
    public class show_chats
    {//start of class

        
        public void chats()
        {//start of the chats method

            //chatBot name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("VANTA:   ");

            //chatbot asking a question
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello there!! VANTA is at your assistance. Enter your name. ");

            //resetting the color
            Console.ResetColor();

            //user's name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Helen:   ");

            //user asking a question
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What is cybersecurity all about?");

            //resetting the color
            Console.ResetColor();

        }//end of the chats method
        
    }//end of class
}//end of namespace