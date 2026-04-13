using System;
using System.Collections;
using System.Configuration;
using System.Drawing;

namespace cybersecurity_chatbot_project
{//start of namespace
    public class search_and_chat
    {//start of class
        
        //arrays to answers and what to avoid
        ArrayList answers = new ArrayList();
        ArrayList avoid = new ArrayList();

        //start of the search method
        public void chatbot(string username)
        {//start of void method

            //adding the answers
            answers.Add("Cybersecurity is all about staying safe online");
            answers.Add("Vanta I am not sure about the answer");
            answers.Add("ask another question");

            //words to avoid
            avoid.Add("I");
            avoid.Add("am");
            avoid.Add("about");
            avoid.Add("ask");
            avoid.Add("question");

            //staring the search
            string request = string.Empty;

            do
            { //start of do-while
                //ask
                Console.Write(username + "    :");
                request = Console.ReadLine();

            } while (exit(request) );
            
        }//end of void method

        //boolean method to check if request is exit or not
        private Boolean exit(string request)
        {//start of boolean method

            //checking
            if (request.ToLower() == "exit")
            {//start of if statement

                //exit the app
                System.Environment.Exit(0);
                return false;

            }//end of if statement
            else
            {//start of else

                //search
                //and store word for word
                string[] words = request.Split(  );

                //two temporary variables for checking
                string temp_answer = "";
                bool answer_found = false;

                //foreach loop for inner and outer
                foreach(string show_words in words)
                {//start of foreach outer loop

                    foreach(string find_answer in answers)
                    {//start of inner loop

                        //checking and avoiding
                        if(find_answer.Contains(show_words) && !avoid.Contains(show_words))
                        {//start of if statement

                            //displaying the answer
                            Console.Write("VANTA:      ");
                            Console.WriteLine(find_answer);
                            answer_found = true;

                            break;
                        }//end of if statement
                    }//end of inner loop

                    //then break
                    if (answer_found){
                        break;
                    }
                }
                return true;

            }
        }
        
    }//end of class
}//end of namespace