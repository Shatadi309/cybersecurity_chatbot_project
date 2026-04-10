using System;

namespace cybersecurity_chatbot_project
{//start of namespace
    public class welcome_user
    {//start of class

        //storing a global variable
        private string user = string.Empty;

        //void method to welcome the user
        public void welcome()
        {//start of the welcome method

            //output the welcome method
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[ Welcome VANTA  cybersecurity ] ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************");

            //reset the color
            Console.ResetColor();

        }//end of method

        //method to ask user input
        public void ask_userInput()
        {//start of ask_userInput method

            //Displaying the AI message with text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("VANTA:  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter your name:   ");

            //resetting the color
            Console.ResetColor();

            //do-while loop to prompt user for their username
            do
            {//start of the do-while loop

                //prompt user for username with text color
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("USER:  ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                user = Console.ReadLine();

            } while (!empty());//end of do-while loop

        }//end of ask_userInput method

        //Boolean method to if user entered their username
        private Boolean empty()
        {//start of boolean method
            if (user != "")
            {//start of if statement 
                //displaying the message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("VANTA:  ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Hello  " + user);

                //returning true
                return true;
            }//end of if statement
            else
            {//start of else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("VANTA:  ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter your name:  ");

                //returing false
                return false;

            }//end of else

        }//end of boolean method

        
    }//end of class
}//end of namespace