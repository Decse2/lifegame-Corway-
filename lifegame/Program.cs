using System;

namespace CustomConsoleWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the console window size.
            Console.SetBufferSize(80, 40);

            // Set the initial cursor position.
            Console.SetCursorPosition(0, 0);

            // Draw a simple "window" border.
            for (int i = 0; i < 80; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");

                Console.SetCursorPosition(i, 39);
                Console.Write("*");
            }

            for (int i = 1; i < 39; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");

                Console.SetCursorPosition(79, i);
                Console.Write("*");
            }

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("This is a custom console 'window'.");

            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
        }
    }
}