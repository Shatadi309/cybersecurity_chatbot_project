using System;
using System.Media;

namespace cybersecurity_chatbot_project
{//start of namespace
    public class bot_greeting
    {//start of class
        public bot_greeting()
        {//start of the constructor

            //calling the greeting method
            greeting();

        }//end of constructor

        //method to play the greeting

        private void greeting()
        {//start of the method

            //auto get the path of the greeting
            string path = AppDomain.CurrentDomain.BaseDirectory;

            //renaming the path
            string fullpath = path.Replace(@"bin\Debug\", "botGreeting.wav");

            //load the audio and play the audio
            SoundPlayer record_play = new SoundPlayer(fullpath);

            //load the greeting
            record_play.Load();

            //play the audio
            record_play.Play();

        }//end of method
    }//end of class
}//end of namespace