using System;
using System.Threading.Tasks;

namespace MarsRoverConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine(" ▄▄   ▄▄ ▄▄▄▄▄▄ ▄▄▄▄▄▄   ▄▄▄▄▄▄▄    ▄▄▄▄▄▄   ▄▄▄▄▄▄▄ ▄▄   ▄▄ ▄▄▄▄▄▄▄ ▄▄▄▄▄▄ ");
            Console.WriteLine(" █  █▄█  █      █   ▄  █ █       █  █   ▄  █ █       █  █ █  █       █   ▄  █ ");
            Console.WriteLine(" █       █  ▄   █  █ █ █ █  ▄▄▄▄▄█  █  █ █ █ █   ▄   █  █▄█  █    ▄▄▄█  █ █ █ ");
            Console.WriteLine(" █       █ █▄█  █   █▄▄█▄█ █▄▄▄▄▄   █   █▄▄█▄█  █ █  █       █   █▄▄▄█   █▄▄█▄ ");
            Console.WriteLine(" █       █      █    ▄▄  █▄▄▄▄▄  █  █    ▄▄  █  █▄█  █       █    ▄▄▄█    ▄▄  █ ");
            Console.WriteLine(" █ ██▄██ █  ▄   █   █  █ █▄▄▄▄▄█ █  █   █  █ █       ██     ██   █▄▄▄█   █  █ █ ");
            Console.WriteLine(" █▄█   █▄█▄█ █▄▄█▄▄▄█  █▄█▄▄▄▄▄▄▄█  █▄▄▄█  █▄█▄▄▄▄▄▄▄█ █▄▄▄█ █▄▄▄▄▄▄▄█▄▄▄█  █▄█ ");
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            while (true)
            {
                try
                {
                    // Initialize variables
                    MarsRover rover1 = new MarsRover();
                    MarsRover rover2 = new MarsRover();
                    string plateau;

                    // Initialize Plateau environment for the rovers
                    Console.WriteLine("Please enter a valid plateau using this format ==> '5 5' or '8 8'");
                    plateau = Console.ReadLine();
                    rover1.InitializePlateau(plateau);
                    rover2.InitializePlateau(plateau);
                    Console.Clear();

                    // Enter Position values for Rover 1.
                    Console.WriteLine("Please enter values for Rover Number 1");
                    Console.WriteLine("Please enter a valid Rover position and cardinal position using this format ==> '1 2 N'");
                    rover1.InitializeMarsRoverPos(Console.ReadLine());
                    Console.WriteLine();

                    // Enter Movement values for Rover 1.
                    Console.WriteLine("Please enter string of commands for Rover Number 1(L = LeftSpin, R = RightSpin, M = StepForward)");
                    rover1.RunInstructions(Console.ReadLine());
                    Console.Clear();

                    // Enter Position values for Rover 2.
                    Console.WriteLine("Please enter value for Rover Number 2");
                    Console.WriteLine("Please enter a valid Rover position and cardinal position using this format ==> '1 2 N'");
                    rover2.InitializeMarsRoverPos(Console.ReadLine());
                    Console.WriteLine();

                    // Enter Movement values for Rover 1.
                    Console.WriteLine("Please enter string of commands for Rover Number 2(L = LeftSpin, R = RightSpin, M = StepForward)");
                    rover2.RunInstructions(Console.ReadLine());
                    Console.Clear();

                    // Display new position based on input. 
                    Console.WriteLine("Rover Number 1 is now in position : " + rover1.x + " " + rover1.y + " " + rover1.direction);
                    Console.WriteLine("Rover Number 2 is now in position : " + rover2.x + " " + rover2.y + " " + rover2.direction);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("An unexpected error occured. Restarting the Mars Rover App....");
                    Console.WriteLine();
                    Console.WriteLine();
                    continue;
                }
            }
        }

    }
}
