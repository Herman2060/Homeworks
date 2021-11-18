using System;
using System.IO;
using System.Net.Mime;
using System.Runtime.InteropServices;

namespace BallGame
{
    public class GameField
    {
        private static int _x = 10;
        private static int _y = 10;
        
        private string path = @"C:\Users\gpoyd\RiderProjects\Task1.3\BallGame\Ball.txt";

        private static (int, int) _ballPosition;

        private static GameField instance;

        private GameField() { }

        public int Rows
        {
            get => _x;
            set
            {
                if (value > 0)
                {
                    _x = value;
                }
            }
        }

        public int Colums
        {
            get => _y;
            set
            {
                if (value > 0)
                {
                    _y = value;
                }
            }
        }

        public static GameField Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameField();
                }

                return instance;
            }
        }

        public void RandomMoveBall()
        {

            try
            {
                for (int i = 0; i < _x * _y; i++)
                {
                    Random rand = new Random();
                        _ballPosition.Item1 = rand.Next(-2, _x + 2);
                        _ballPosition.Item2 = rand.Next(-2, _y + 2);
                        
                        FileWrite(_ballPosition);
                        
                        if (_ballPosition.Item1 <= 0 || _ballPosition.Item1 >= _x)
                        {
                            throw new CustomException(ToString());
                        }

                        if (_ballPosition.Item2 <= 0 || _ballPosition.Item2 >= _y)
                        {
                            throw new CustomException(ToString());
                        }
                }
                
            }
            catch (CustomException exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }
        }

        private void FileWrite((int,int)  ballPos)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.Write(ballPos.ToString());
            }
        }
        
    }
}