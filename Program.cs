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
                    MarsRover rover1 = new MarsRover();
                    MarsRover rover2 = new MarsRover();
                    string plateau;


                    Console.WriteLine("Please enter a valid plateau using this format ==> '5 5' or '8 8'");
                    plateau = Console.ReadLine();
                    rover1.InitializePlateau(plateau);
                    rover2.InitializePlateau(plateau);
                    Console.Clear();

                    Console.WriteLine("Please initialize value for Rover Number 1");
                    Console.WriteLine("Please enter a valid Rover position and cardinal position using this format ==> '1 2 N'");
                    rover1.InitializeMarsRoverPos(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Please enter string of commands for Rover Number 1(L = LeftSpin, R = RightSpin, M = StepForward)");
                    rover1.RunInstructions(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Please initialize value for Rover Number 2");
                    Console.WriteLine("Please enter a valid Rover position and cardinal position using this format ==> '1 2 N'");
                    rover2.InitializeMarsRoverPos(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Please enter string of commands for Rover Number 2(L = LeftSpin, R = RightSpin, M = StepForward)");
                    rover2.RunInstructions(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Rover Number is now in position : " + rover1.x + " " + rover1.y + " " + rover1.direction);
                    Console.WriteLine("Rover Number is now in position : " + rover2.x + " " + rover2.y + " " + rover2.direction);
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
