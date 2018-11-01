// * Implement the "Falling Rocks" game in the text console. 
// A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). 
// A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
// Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. 
// The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
// Implement collision detection and scoring system.

using System;
using System.IO;
using System.Text;
using System.Threading;

class FallingRocks
{
    static Random randomGenerator = new Random(); // A generator of random integers
    static int dwarfPosition = 0; // The position of the player
    static int dwarfSize = 3; // The size of the player
    static int difficulty = 1; // Difficulty. It increases over time, spawning more rocks per row as time passes.
    static int speed = 200; // The speed at which the rocks are generated, can be changed ingame by up arrow and down arrow
    static int score = 1; // The number of rows that the player has dodged
    static int topScore = 0; // The top score he has scored in the current session
    static int sizeOfString = Console.WindowHeight - 3; // The size of each row
    static string[] stones = new string[sizeOfString]; // This is an array of all the rows of stones
    static readonly char[] rockTypes = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' }; // All the stone types

    static void RemoveScrollBars() 
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static void PrintAtPosition(int x, int y, char symbol) // This prints the symbols of the player!
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
        Console.ForegroundColor = ConsoleColor.Red;
    }

    static void MoveDwarf() // The function that moves the dwarf, and increases the speed
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (dwarfPosition > 0)
                {
                    dwarfPosition--;
                }
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (dwarfPosition < Console.WindowWidth - dwarfSize)
                {
                    dwarfPosition++;
                }
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (speed > 100)
                    speed -= 10;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (speed < 300)
                    speed += 10;
            }
        }
    }

    static void MoveRows() // A function that moves the rows
    {
        for (int i = sizeOfString - 1; i > 0; i--)
        {
            stones[i] = stones[i - 1];
        }
    }

    static void GenerateNewRow() // A function that generates a new random row at the top
    {
        stones[0] = new string(' ', Console.WindowWidth); // Empty row (string)
        if (score % 2 == 0) // We generate every second row. (1 row, 1 blank)
        {
            int position;
            int numberOfChars;
            string temp;
            char randomChar;
            int randomInt;
            for (int i = 0; i < difficulty; i++) // As the difficulty increases we generate more rocks per row!
            {
                position = randomGenerator.Next(0, Console.WindowWidth - 2); // The random position where we create a rock
                numberOfChars = randomGenerator.Next(1, 4); // A random size of the rock [1-4)
                StringBuilder aStringBuilder = new StringBuilder(stones[0]); // We create a StringBuilder
                aStringBuilder.Remove(position, numberOfChars); // We say which random position and how large a rock we will make
                randomInt = randomGenerator.Next(0, 12); // We pick a random integer [0-12)
                randomChar = rockTypes[randomInt]; // We pick the random rock we will be using
                temp = new string(randomChar, numberOfChars); // We use the random rock and the number of positions
                aStringBuilder.Insert(position, temp); // We insert them in the string row
                stones[0] = aStringBuilder.ToString(); 
            }
        }
    }

    static void Collision()
    {
        if (CollisionDetection() == 1) // If there has been a collision... 
        {
            if (score > topScore)
            {
                topScore = score; // We save the score if needed
            }
            score = 0; // We reset all the game data.
            speed = 200;
            dwarfPosition = (Console.WindowWidth - dwarfSize) / 2;
            difficulty = 1;
            ClearRows(); // Clear all the rows
            ConsoleKeyInfo keyInfo;
            do
            {
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2 - 1);
                    Console.Write("GAME OVER");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 + 1);
                    Console.Write("Press ENTER to start a new game!");
                    keyInfo = Console.ReadKey();
            }while (keyInfo.Key != ConsoleKey.Enter);
        }
    }

    static int CollisionDetection()
    {
        int flagForCollision = 1;
        if (stones[Console.WindowHeight - 4].Substring(dwarfPosition, dwarfSize).Contains("   "))
        {
            flagForCollision = 0; // If we the position where the player is has only blank spaces, we set the Collision flag to 0
        }
        return flagForCollision;
    }

    static void DrawRows()
    {
        for (int i = 0; i < sizeOfString; i++)
        {
            Console.Write("{0}", stones[i]);
        }
    }

    static void DrawDwarf()
    {
        for (int x = 0; x < dwarfSize; x++)
        {
            PrintAtPosition(dwarfPosition + x, Console.WindowHeight - 4, '^');
            Console.SetCursorPosition(0, Console.WindowHeight - 3);
            Console.Write(new string('-', Console.WindowWidth));
        }
    }

    static void ShowScore()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.Write("Score: {0}", score);
        Console.SetCursorPosition(12, Console.WindowHeight - 1);
        Console.Write("Difficulty: {0}", difficulty);
        Console.SetCursorPosition(12, Console.WindowHeight - 2);
        Console.Write("Top Score: {0}", topScore);
        Console.SetCursorPosition(30, Console.WindowHeight - 2);
        Console.WriteLine("Left Arrow: Move Left");
        Console.SetCursorPosition(30, Console.WindowHeight - 1);
        Console.Write("Right Arrow: Move Right");
        Console.SetCursorPosition(60, Console.WindowHeight - 2);
        Console.WriteLine("Up Arrow: + Speed");
        Console.SetCursorPosition(60, Console.WindowHeight - 1);
        Console.Write("Down Arrow: - Speed");
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.Write("Speed: {0}", 300 - speed);
        Console.ForegroundColor = ConsoleColor.Red;
        score++;
        if (score % 100 == 0)
            difficulty++; // We increase the difficulty every 100 score points!
    }

    static void ClearRows()
    {
        for (int i = 0; i < sizeOfString; i++)
        {
            stones[i] = new string(' ', Console.WindowWidth);
        }
    }


    static void Main()
    {
        Console.Title = "Falling Rocks";
        RemoveScrollBars();
        ClearRows();
        dwarfPosition = (Console.WindowWidth - dwarfSize) / 2;

        while (true)
        {
            MoveDwarf();
            MoveRows();
            GenerateNewRow();
            Collision();
            Console.Clear();
            DrawRows();
            DrawDwarf();
            ShowScore();
            Thread.Sleep(speed);
        }
    }
}
