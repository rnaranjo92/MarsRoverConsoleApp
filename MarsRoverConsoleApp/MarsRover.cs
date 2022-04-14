using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverConsoleApp
{
    public class MarsRover
    {
        public int x;
        public int y;
        public string direction;
        public int maxX;
        public int maxY;


        /// <summary>
        /// Dictionary to hold values equivalent to the supplied cardinal point value
        /// </summary>
        private Dictionary<string, string> cardinalDictionaryOnLeft = new Dictionary<string, string>()
        {
            { "N", "W" },
            { "W", "S" },
            { "S", "E" },
            { "E", "N" },
        };

        /// <summary>
        /// Dictionary to hold values equivalent to the supplied cardinal point value
        /// </summary>
        private Dictionary<string, string> cardinalDictionaryOnRight = new Dictionary<string, string>()
        {
            { "N", "E" },
            { "W", "N" },
            { "S", "W" },
            { "E", "S" },
        };

        /// <summary>
        /// This initializes the plateau for the MarsRover object
        /// </summary>
        public void InitializePlateau(string plateau)
        {
            Int32.TryParse(plateau.Split(" ")[0], out maxX);
            Int32.TryParse(plateau.Split(" ")[1], out maxY);
        }


        /// <summary>
        /// This initializes the position for the MarsRover object
        /// </summary>
        public void InitializeMarsRoverPos(string position)
        {
            if (position.Length > 0)
            {
                Int32.TryParse(position.Split(" ")[0], out x);
                Int32.TryParse(position.Split(" ")[1], out y);
                direction = position.Split(" ")[2];
            }
            else
            {
                Console.WriteLine("Unable to initialize values for MarsRover position");
            }
        }


        /// <summary>
        /// Changes the heading of the Rover to its right
        /// </summary>
        public void Right()
        {
            if (cardinalDictionaryOnRight.ContainsKey(direction))
            {
                direction = cardinalDictionaryOnRight[direction];
            }
            else
            {
                Console.WriteLine("Invalid Cardinal Point Right Spin");
            }
        }

        /// <summary>
        /// Changes the heading of the Rover to its left
        /// </summary>
        public void Left()
        {
            if (cardinalDictionaryOnLeft.ContainsKey(direction))
            {
                direction = cardinalDictionaryOnLeft[direction];
            }
            else
            {
                Console.WriteLine("Invalid Cardinal Point for Left Spin");
            }

        }

        /// <summary>
        /// Rover moves one step forward
        /// </summary>
        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    if (y < maxY) // checks if its out of bounds
                    {
                        y++;
                    }
                    else
                    {
                        Console.WriteLine("y axis passed the maximum amount. Restarting the Mars Rover App....");
                        Console.WriteLine();
                        Console.WriteLine();
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                case "W":
                    if (x > 0)  // checks if its out of bounds
                    {
                        x--;
                    }
                    else
                    {
                        Console.WriteLine("x axis passed the minimum amount. Restarting the Mars Rover App....");
                        Console.WriteLine();
                        Console.WriteLine();
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                case "E":
                    if (x < maxX)  // checks if its out of bounds
                    {
                        x++;
                    }
                    else
                    {
                        Console.WriteLine("x axis passed the maximum amount. Restarting the Mars Rover App....");
                        Console.WriteLine();
                        Console.WriteLine();
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                case "S":
                    if (y > 0)  // checks if its out of bounds
                    {
                        y--;
                    }
                    else
                    {
                        Console.WriteLine("y axis passed the minimum amount. Restarting the Mars Rover App....");
                        Console.WriteLine();
                        Console.WriteLine();
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    Console.WriteLine("Error occured when stepping forward. The direction is : " + direction);
                    break;
            }
        }

        /// <summary>
        /// Runs the string of instructions provided.
        /// </summary>
        public void RunInstructions(string instructions)
        {
            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case 'L':
                        Left();
                        break;
                    case 'R':
                        Right();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        Console.WriteLine("Error occured running the instruction. At instruction " + instruction);
                        break;
                }
            }
        }
    }
}
