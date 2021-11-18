using System;
using System.IO;

namespace BallGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gpoyd\RiderProjects\Task1.3\BallGame\Ball.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
            GameField.Instance.RandomMoveBall();
        }
    }
    
}