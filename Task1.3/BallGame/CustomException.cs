using System;
using System.IO;

namespace BallGame
{
    public class CustomException : Exception
    {
        string path = @"C:\Users\gpoyd\RiderProjects\Task1.3\BallGame\Ball.txt";
        
        public CustomException(string message) : base(message)
        {
            
        }

        public override string Message
        {
            get
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
        }
        
    }
}