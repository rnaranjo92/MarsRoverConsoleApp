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

        private Dictionary<string, string> cardinalDictionaryOnLeft = new Dictionary<string, string>() 
        { 
            { "N", "W" },
            { "W", "S" },
            { "S", "E" },
            { "E", "N" },
        };

        private Dictionary<string, string> cardinalDictionaryOnRight = new Dictionary<string, string>()
        {
            { "N", "E" },
            { "W", "N" },
            { "S", "W" },
            { "E", "S" },
        };

        public void InitializePlateau(string plateau)
        {
            Int32.TryParse(plateau.Split(" ")[0], out maxX);
            Int32.TryParse(plateau.Split(" ")[1], out maxY);
        }

        public void InitializeMarsRoverPos(string position)
        {
            if (position.Length > 0)
            {
                Int32.TryParse(position.Split(" ")[0], out x);
                Int32.TryParse(position.Split(" ")[1], out y);
                direction = position.Split(" ")[2];
            } else
            {
                Console.WriteLine("Unable to initialize values for MarsRover position");
            }
        }

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

        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    if(y < maxY)
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
                    if(x > 0)
                    {
                        x--;
                    } else
                    {
                        Console.WriteLine("x axis passed the minimum amount. Restarting the Mars Rover App....");
                        Console.WriteLine();
                        Console.WriteLine();
                        throw new ArgumentOutOfRangeException();
                    }
                    break;
                case "E":
                    if (x < maxX)
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
                    if (y > 0)
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
