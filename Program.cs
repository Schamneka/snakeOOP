using System;

namespace snakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2;
            int y1 = 7;
            char sym1 = '*';

            Draw( x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw( x2, y2, sym2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
        Console.SetCursorPosition( x, y );
        Console.Write( sym );    
        }
    }
}
