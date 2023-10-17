namespace Tik_Tak_Toe_console
{
    internal class Program
    {
        public static bool inGame = true;
        public static char xoro = 'x';

        static void Main(string[] args)
        {
            char[,] map = { {'.','.','.'},
                            {'.','.','.' },
                            {'.','.','.' }
                          };

            while (inGame == true)
            {
                try
                {
                    string[] line;
                    int[] chosen = new int[2];

                    Console.WriteLine("\t1\t2\t3");
                    Console.WriteLine($"1\t{map[0, 0]}   |   {map[0, 1]}   |   {map[0, 2]}");
                    Console.WriteLine("\t-   -   -   -   -");
                    Console.WriteLine($"2\t{map[1, 0]}   |   {map[1, 1]}   |   {map[1, 2]}");
                    Console.WriteLine("\t-   -   -   -   -");
                    Console.WriteLine($"3\t{map[2, 0]}   |   {map[2, 1]}   |   {map[2, 2]}");
                    Console.Write("Adj meg egy mezőt: ");

                    line = Console.ReadLine().Split(',');    
                    int.TryParse(line[0], out chosen[0]);
                    int.TryParse(line[1], out chosen[1]);

                    if(map[chosen[1] - 1, chosen[0] - 1] == 'x' || map[chosen[1] - 1, chosen[0] - 1] == 'o')
                    {
                        Console.WriteLine("Ez a mező már foglalt!");
                    }
                    else
                    {
                        map[chosen[1] - 1, chosen[0] - 1] = xoro;
                        checkEnd(map);
                        if (xoro == 'x')
                        {
                            xoro = 'o';
                        }
                        else xoro = 'x';
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nem jó input!");
                }
            }

            Console.WriteLine("\t1\t2\t3");
            Console.WriteLine($"1\t{map[0, 0]}   |   {map[0, 1]}   |   {map[0, 2]}");
            Console.WriteLine("\t-   -   -   -   -");
            Console.WriteLine($"2\t{map[1, 0]}   |   {map[1, 1]}   |   {map[1, 2]}");
            Console.WriteLine("\t-   -   -   -   -");
            Console.WriteLine($"3\t{map[2, 0]}   |   {map[2, 1]}   |   {map[2, 2]}");

            if (xoro == 'x')
            {
                xoro = 'o';
            }
            else
            {
                xoro = 'x';
            }

            Console.WriteLine($"\nGyőztes: {xoro}");

        }

        static void gameEnd()
        {
            inGame = false;
        }

        static void checkEnd(char[,] map)
        {
            if (map[0, 0] == map[0, 1] && map[0, 0] == map[0, 2] && map[0, 0] != '.')
            {
                gameEnd();
                xoro = map[0, 0];
            } 
            else if (map[1, 0] == map[1, 1] && map[1, 0] == map[1, 2] && map[1, 0] != '.')
            {
                gameEnd();
                xoro = map[1, 0];
            } 
            else if (map[2, 0] == map[2, 1] && map[2, 0] == map[2, 2] && map[2, 0] != '.')
            {
                gameEnd();
                xoro = map[2, 0];
            }
            else if (map[0, 0] == map[1, 0] && map[0, 0] == map[2, 0] && map[0, 0] != '.')
            {
                gameEnd();
                xoro = map[0, 0];
            }
            else if (map[0, 1] == map[1, 1] && map[0, 1] == map[2, 1] && map[0, 1] != '.')
            {
                gameEnd();
                xoro = map[0, 1];
            }
            else if (map[0, 2] == map[1, 2] && map[0, 2] == map[2, 2] && map[0, 2] != '.')
            {
                gameEnd();
                xoro = map[0, 2];
            }
            else if (map[0, 0] == map[1, 1] && map[0, 0] == map[2, 2] && map[0, 0] != '.')
            {
                gameEnd();
                xoro = map[0, 0];
            }
            else if (map[0, 2] == map[1, 1] && map[0, 2] == map[2, 0] && map[0, 2] != '.')
            {
                gameEnd();
                xoro = map[0, 2];
            }
        }
    }
}