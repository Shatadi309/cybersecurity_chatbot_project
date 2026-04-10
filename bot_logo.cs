using System;
using System.Drawing;

namespace cybersecurity_chatbot_project
{//start of namespace
    public class bot_logo
    {//start of class

        public bot_logo()
        {//start of the constructor

            //calling the logo method
            logo();

        }//end of the constructor

        private void logo()
        {//start of the void method

            //path of the image [where the image is]
            string path = string.Empty;

            //auto get the fullpath
            string fullpath = AppDomain.CurrentDomain.BaseDirectory;

            //combining the paths
            path = fullpath.Replace(@"bin\Debug\", "logo.jpg");

            Bitmap image = new Bitmap(path);

            //resizing for better console fit
            int width = 100;
            int height = 50;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            //default color 
            Console.ForegroundColor = ConsoleColor.Green;
            string asciiChars = "*@#';:";

            //start setting by height
            for (int y = 0; y < resized.Height; y++)
            {//start of the outer loop

                //then set by width
                for (int x = 0; x < resized.Width; x++)
                {//start of inner loop

                    //Color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    //Converting to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    //Map the grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;


                    Console.Write(asciiChars[index]);
                }//end of inner loop
                Console.WriteLine();
            }//end of outer loop
        }//end of the void method

    }//end of class
       
}//end of namespace 