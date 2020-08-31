using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {


        bool _gameOver = false;
        string _playerName;


        void SetName()
        {
            char input = ' ';
            while (input != '1')
            {
                Console.Clear();
                Console.WriteLine("\nYoung spirit, speak of your name");
                _playerName = Console.ReadLine();
                Console.WriteLine("\nI see, your name is " + _playerName);
                input = GetInput("yes", "no", "are you sure you want to be named " + _playerName + "?");
                if (input == '2')
                {
                    Console.WriteLine("try again");

                }
            }
        }

        void Explore()
        {
            char input = ' ';
            Console.WriteLine("\nI shall grant you a body in the mortal realm tread thy path carefully younge spirit");
            Console.WriteLine("you wake up on the side of a path that leads into two directions. The left side leads deeper into the forest while the right side seems to lead to an open area");
            input = GetInput("The left path (deep forest", "The right path (open field)", "which path do you wish to take?");
            if (input == '1')
            {
                _gameOver = true;
                ExplorePearl1();
            }
            if (input == '2')
            {
                _gameOver = true;
                ExploreScar1();
            }

        }

        //Pearl's story branch
        void ExplorePearl1()
        {
            //placeholder
            Console.WriteLine("good job :)");
            Console.ReadKey();
            _gameOver = true;
        }


        void ExploreScar1()
        {
            //placeholder
            Console.WriteLine("ok job :/");
            Console.ReadKey();
            _gameOver = true;
        }
        void ViewStats()
        {
            Console.WriteLine(_playerName);
            Console.WriteLine("> ");
            Console.WriteLine("Press Any Key to continue");
            Console.ReadKey();
        }
        char GetInput(string option1, string option2, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine(query);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. View Stats");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input == '3')
                {
                    ViewStats();
                }
            }
            return input;
        }

        //Run the game
        public void Run()
        {
            Start();


            while (_gameOver == false)
            {
                Update();
            }
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            SetName();
            Explore();
            ExplorePearl1();
            ExploreScar1();
        }

        //Repeated until the game ends
        public void Update()

        {

            char input = ' ';

            Console.WriteLine("\nend the game with 1.");
            Console.Write(">");
            input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                _gameOver = true;
            }
            Console.Clear();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nthank :)");
        }
    }
}
