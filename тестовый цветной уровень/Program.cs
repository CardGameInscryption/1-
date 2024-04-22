using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Цветной_уровень
{
    internal class Program
    {

        static private int c;
        static void bot()
        {
            int c = ataca1 - ataca2;

            if (c == 0)
            {
                Console.WriteLine(@"
                     ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }

            else if (c == 1)
            {
                Console.WriteLine(@"
                        ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }
            else if (c == 2)
            {
                Console.WriteLine(@"
                            ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }
            else if (c == 3)
            {
                Console.WriteLine(@"
                                ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }
            else if (c == 4)
            {
                Console.WriteLine(@"
                                   ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }

            else if (c == -1)
            {
                Console.WriteLine(@"
                  ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }
            else if (c == -2)
            {
                Console.WriteLine(@"
              ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }
            else if (c == -3)
            {
                Console.WriteLine(@"
          ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }
            else if (c == -4)
            {
                Console.WriteLine(@"
       ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }

            else if (c < -4)
            {
                Console.WriteLine(@"
       ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }
            else if (c > 4)
            {
                Console.WriteLine(@"
                                   ↓
      !_|___|___|___|-|___|___|___|_!
                ");
            }

            if (ataca1 == ataca2)
            {
                Console.WriteLine(@"        _------------+------------_");
                Console.WriteLine(@"       / \          | |          / \");
                Console.WriteLine(@"      /   \         | |         /   \");
                Console.WriteLine(@"     /" + "  " + ataca2 + "  " + @"\        | |        /" + "  " + ataca1 + "  " + @"\");
                Console.WriteLine(@"    /-_____-\       | |       /-_____-\");
                Console.WriteLine(@"                ___/| |\___");
                Console.WriteLine(@"               /-_________-\");

            }
            else if (ataca1 < ataca2)
            {
                Console.WriteLine(@"                  --+------------_");
                Console.WriteLine(@"        _________/ | |          / \");
                Console.WriteLine(@"       / \         | |         /   \");
                Console.WriteLine(@"      /   \        | |        /" + "  " + ataca1 + "  " + @"\");
                Console.WriteLine(@"     /" + "  " + ataca2 + "  " + @"\       | |       /-_____-\");
                Console.WriteLine(@"    /-_____-\  ___/| |\___");
                Console.WriteLine(@"              /-_________-\");
            }
            else if (ataca1 > ataca2)
            {
                Console.WriteLine(@"        _------------+--");
                Console.WriteLine(@"       / \          | | \__________");
                Console.WriteLine(@"      /   \         | |          / \");
                Console.WriteLine(@"     /" + "  " + ataca2 + "  " + @"\        | |         /   \");
                Console.WriteLine(@"    /-_____-\       | |        /" + "  " + ataca1 + "  " + @"\");
                Console.WriteLine(@"                ___/| |\___   /-_____-\");
                Console.WriteLine(@"               /-_________-\");
            }
            return;
        }
        static void bot_karta()
        {
            if (belka == 1 && gornostai == 1 && cheripaha == 1 && cat == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string[] lines1 = {
            @"----------- ----------- ----------- -----------",
            @"|  БЕЛКА  | |ГОРНОСТАЙ| |ЧЕРЕПАХА | |  КОШКА  |",
            @"|—————————| |—————————| |—————————| |—————————|"
            };
                foreach (string line in lines1)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(@"|"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(@" _  (\_  "); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(""); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("|");
                Console.Write(@" |        "); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("|");
                Console.Write(@" |        "); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("2"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("|");
                Console.Write(@" |"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(@" \    /\"); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("|");

                string[] lines = {
            @"|( \  ( '>| | │\———/│ | |   .^./*)| |  )  ( ')|",
            @"| ) \/_)= | | │ —_— │ | | _/___\/ | | (  /  ) |",
            @"|(_(  )_  | |  \_^_/  | |   U U   | |  \(  )│ |",
            @"|---------| |---------| |---------| |---------|"
            };
                foreach (string line in lines)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(@"| "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("0"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("     "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" | ");
                Console.Write(@"| "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("     "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("3"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" |");
                Console.Write(@" | "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("     "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("6"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" |");
                Console.Write(@" | "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("0"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("  %  "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.ResetColor();
            }
            else if (gornostai == 1 && cheripaha == 1 && cat == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                string[] lines1 = {
            @"——————————— ——————————— ———————————",
            @"|ГОРНОСТАЙ| |ЧЕРЕПАХА | |  КОШКА  |",
            @"|---------| |---------| |---------|"
            };
                foreach (string line in lines1)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(@"|        "); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("|");
                Console.Write(@" |        "); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("2"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("|");
                Console.Write(@" |"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(@" \    /\"); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("|");

                string[] lines = {
            @"| │\———/│ | |   .^./*)| |  )  ( ')|",
            @"| │ -_- │ | | _/___\/ | | (  /  ) |",
            @"|  \_^_/  | |   U U   | |  \(  )│ |",
            @"|---------| |---------| |---------|"
            };
                foreach (string line in lines)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.Write(@"| "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("     "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("3"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" |");
                Console.Write(@" | "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("     "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("6"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" |");
                Console.Write(@" | "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("0"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("  %  "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" |");
                Console.WriteLine(@"——————————— ——————————— ———————————");
                Console.ResetColor();
            }
            else if (gornostai == 1 && cheripaha == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                string[] lines1 = {
            @"——————————— ———————————",
            @"|ГОРНОСТАЙ| |ЧЕРЕПАХА |",
            @"|—————————| |—————————|"
            };
                foreach (string line in lines1)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(@"|        "); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("| ");
                Console.Write(@"|      _ "); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("2"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("|");

                string[] lines = {
            @"| │\———/│ | |   .^./*)|",
            @"| │ -_- │ | | _/___\/ |",
            @"|  \_^_/  | |   U U   |",
            @"|—————————| |—————————|"
            };
                foreach (string line in lines)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(@"| "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("     "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("3"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" | ");
                Console.Write(@"| "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("     "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("6"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" |");
                Console.WriteLine(@"——————————— ———————————");
            }
            else if (cheripaha == 1)
            {
                Console.WriteLine(@"———————————");
                Console.WriteLine(@"|ЧЕРЕПАХА |");
                Console.WriteLine(@"|—————————|");
                Console.Write(@"|      _ "); Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("2"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|");
                Console.WriteLine(@"|  .^./*) |");
                Console.WriteLine(@"|_/___\/  |");
                Console.WriteLine(@"|  U U    |");
                Console.WriteLine(@"|—————————|");
                Console.Write(@"| "); Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("     "); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("6"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" |");
                Console.WriteLine(@"———————————");
            }
        }

        public static int Leavel3_Gagyka_ili_kosha = 2;

        public static int ataca1;
        public static int ataca2;

        public static int gornostai;
        public static int cheripaha;
        public static int gadyca;
        public static int cat;
        public static int belka;
        public static int volk;

        public static int polozi_carty_mesto;

        public static int karta_zertva2;
        static void pole()
        {
            void promezytoc()
            {
                string[] lines1 = new string[] {
            @"——————————— ——————————— ——————————— ———————————",
            @"|   | |   | |ВОЛЧЁНОК | |   | |   | |   | |   |",
            @"|   | |   | |—————————| |   | |   | |   | |   |",
            @"|   | |   | | │\___/│ | |   | |   | |   | |   |",
            @"|   | |   | | │)o o(│ | |   | |   | |   | |   |",
            @"||———————|| |  \_0_/  | ||———————|| ||———————||",
            @"| |     | | |         | | |     | | | |     | |",
            @"|  |   |  | |—————————| |  |   |  | |  |   |  |",
            @"|   |—|   | | 1  $  l | |   |—|   | |   |—|   |",
            @"——————————— ——————————— ——————————— ———————————",
            };
                foreach (string line in lines1)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (c == 'l')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            void promezytoc1()
            {
                string[] lines1 = new string[]
                   {
                @"----------- ----------- ----------- -----------",
                @"|  пень   | |         | |  пень   | |         |",
                @"|.........| |         | |.........| |         |",
                @"|         | |         | |         | |         |",
                @"| │\_  /│ | |         | | │\_  /│ | |         |",
                @"| │  \/ │ | |         | | │  \/ │ | |         |",
                @"| │_____\ | |         | | │_____\ | |         |",
                @"|.........| |         | |.........| |         |",
                @"|       3 | |         | |       3 | |         |",
                @"----------- ----------- ----------- -----------",
                   };
                foreach (string line in lines1)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '.')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '3')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            promezytoc();
            promezytoc1();
        }
        static void promezytoc0()
        {
            string[] lines1 = new string[] {
            @"——————————— ——————————— ——————————— ———————————",
            @"|   | |   | |ВОЛЧЁНОК | |   | |   | |   | |   |",
            @"|   | |   | |—————————| |   | |   | |   | |   |",
            @"|   | |   | | │\___/│ | |   | |   | |   | |   |",
            @"|   | |   | | │)o o(│ | |   | |   | |   | |   |",
            @"||———————|| |  \_0_/  | ||———————|| ||———————||",
            @"| |     | | |         | | |     | | | |     | |",
            @"|  |   |  | |—————————| |  |   |  | |  |   |  |",
            @"|   |—|   | | 1  $  l | |   |—|   | |   |—|   |",
            @"——————————— ——————————— ——————————— ———————————",
            };
            foreach (string line in lines1)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (c == '—')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (c == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (c == 'l')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void promezytoc1()
        {
            promezytoc0();
            string[] lines1 = new string[]
               {
                @"----------- ----------- ----------- -----------",
                @"|  пень   | |         | |  пень   | |         |",
                @"|—————————| |         | |—————————| |         |",
                @"|         | |         | |         | |         |",
                @"| │\_  /│ | |         | | │\_  /│ | |         |",
                @"| │  \/ │ | |         | | │  \/ │ | |         |",
                @"| │_____\ | |         | | │_____\ | |         |",
                @"|—————————| |         | |—————————| |         |",
                @"|       3 | |         | |       3 | |         |",
                @"----------- ----------- ----------- -----------",
               };
            foreach (string line in lines1)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '—')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (c == '3')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (c == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void promezytoc1_ataca_peni_1()
        {
            promezytoc0();
            string[] lines1 = new string[]
               {
                @"----------- ----------- ----------- -----------",
                @"|  пень   | |         | |  пень   | |         |",
                @"|—————————| |         | |—————————| |         |",
                @"|         | |         | |         | |         |",
                @"| │\_  /│ | |         | | │\_  /│ | |         |",
                @"| │  \/ │ | |         | | │  \/ │ | |         |",
                @"| │_____\ | |         | | │_____\ | |         |",
                @"|—————————| |         | |—————————| |         |",
                @"|       3 | |         | |       3 | |         |",
                @"----------- ----------- ----------- -----------",
               };
            foreach (string line in lines1)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '—')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (c == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        static void belka1()
        {
            Console.Clear();
            promezytoc1();
            string[] lines2 = new string[]
                {
                @"––––––––––– ––––––––––– ––––––––––– –––––––––––",
                @"|  БЕЛКА  | | камень  | |         | |         |",
                @"|---------| |---------| |         | |         |",
                @"| _  (\_  | | ___     | |         | |         |",
                @"|( \  ( '>| ||___\_   | |         | |         |",
                @"| ) \/_)= | ||_____\_ | |         | |         |",
                @"|(_(__)_  | ||_______\| |         | |         |",
                @"|---------| |---------| |         | |         |",
                @"| 0     1 | |       5 | |         | |         |",
                @"––––––––––– ––––––––––– ––––––––––– –––––––––––"
                };
            foreach (string line in lines2)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '–')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '5' || c == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (c == '0')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (c == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void zertva_belka1()
        {
            Console.Clear();
            promezytoc1();
            string[] lines = new string[] {
            @"——————————— ——————————— ——————————— ———————————",
            @"|\ БЕЛКА /| | КАМЕНЬ  | |         | |         |",
            @"|\\—————//| |---------| |         | |         |",
            @"| \\ ( // | | ___     | |         | |         |",
            @"|( \\ //'>| |│___)_   | |         | |         |",
            @"| )// \\= | |│_____)_ | |         | |         |",
            @"|(//__)\\ | |│_______)| |         | |         |",
            @"|//—————\\| |---------| |         | |         |",
            @"|/       \| |       5 | |         | |         |",
            @"——————————— ——————————— ——————————— ———————————",
            };
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '—')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '5')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (c == '/')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (c == '\\')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void belka3()
        {
            Console.Clear();
            promezytoc1();
            string[] lines2 = new string[]
                {
                @"––––––––––– ––––––––––– ––––––––––– –––––––––––",
                @"|         | | камень  | |  БЕЛКА  | |         |",
                @"|         | |---------| |---------| |         |",
                @"|         | | ___     | | _  (\_  | |         |",
                @"|         | ||___\_   | |( \  ( '>| |         |",
                @"|         | ||_____\_ | | ) \/_)= | |         |",
                @"|         | ||_______\| |(_(__)_  | |         |",
                @"|         | |---------| |---------| |         |",
                @"|         | |       5 | | 0     1 | |         |",
                @"––––––––––– ––––––––––– ––––––––––– –––––––––––"
                };
            foreach (string line in lines2)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '–')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '5' || c == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (c == '0')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (c == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void zertva_belka3()
        {
            Console.Clear();
            promezytoc1();
            string[] lines = new string[] {
            @"——————————— ——————————— ——————————— ———————————",
            @"|         | | КАМЕНЬ  | |\ БЕЛКА /| |         |",
            @"|         | |---------| |\\—————//| |         |",
            @"|         | | ___     | | \\ ( // | |         |",
            @"|         | |│___)_   | |( \\ //'>| |         |",
            @"|         | |│_____)_ | | )// \\= | |         |",
            @"|         | |│_______)| |(//__)\\ | |         |",
            @"|         | |---------| |//—————\\| |         |",
            @"|         | |       5 | |/       \| |         |",
            @"——————————— ——————————— ——————————— ———————————",
            };
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '—')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '5')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (c == '/')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (c == '\\')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void belka4()
        {
            Console.Clear();
            promezytoc1();
            string[] lines2 = new string[]
                {
                @"––––––––––– ––––––––––– ––––––––––– –––––––––––",
                @"|         | | камень  | |         | |  БЕЛКА  |",
                @"|         | |---------| |         | |---------|",
                @"|         | | ___     | |         | | _  (\_  |",
                @"|         | ||___\_   | |         | |( \  ( '>|",
                @"|         | ||_____\_ | |         | | ) \/_)= |",
                @"|         | ||_______\| |         | |(_(__)_  |",
                @"|         | |---------| |         | |---------|",
                @"|         | |       5 | |         | | 0     1 |",
                @"––––––––––– ––––––––––– ––––––––––– –––––––––––"
                };
            foreach (string line in lines2)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '–')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '5' || c == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (c == '0')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (c == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void zertva_belka4()
        {
            Console.Clear();
            promezytoc1();
            string[] lines = new string[] {
            @"——————————— ——————————— ——————————— ———————————",
            @"|         | | КАМЕНЬ  | |         | |\ БЕЛКА /|",
            @"|         | |---------| |         | |\\—————//|",
            @"|         | | ___     | |         | | \\ ( // |",
            @"|         | |│___)_   | |         | |( \\ //'>|",
            @"|         | |│_____)_ | |         | | )// \\= |",
            @"|         | |│_______)| |         | |(//__)\\ |",
            @"|         | |---------| |         | |//—————\\|",
            @"|         | |       5 | |         | |/       \|",
            @"——————————— ——————————— ——————————— ———————————",
            };
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '—')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (c == '5')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (c == '/')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (c == '\\')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public static int vibor_cart;
        static void leavel()
        {
            void chast1()
            {
                pole();
                Console.Write("***** - ");
                {
                    string te = "Ты попал в засаду по среди бездорожья.";
                    int ad = 100;
                    foreach (char c in te)
                    {
                        Console.Write(c);
                        Thread.Sleep(ad);
                    }
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.Clear();
                }

                karta_mestnosti();

                Console.Write("***** - ");
                {
                    string fraza = "Теперь ты можешь видеть мою предстоящую атаку.";
                    int vrema = 100;
                    foreach (char c in fraza)
                    {
                        Console.Write(c);
                        Thread.Sleep(vrema);
                    }
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                karta_mestnosti();
                Console.Clear();

                while (true)
                {
                    if (Leavel3_Gagyka_ili_kosha == 1)
                    {
                        karta_mestnosti();
                        belka = 1;
                        gornostai = 1;
                        cheripaha = 1;
                        gadyca = 1;
                        bot_karta();

                        Thread.Sleep(500);
                        Console.WriteLine("1) Белка.");
                        belka = 1;

                        Thread.Sleep(500);
                        Console.WriteLine("2) Горностай.");
                        gornostai = 1;

                        Thread.Sleep(500);
                        Console.WriteLine("3) Черепаха.");
                        cheripaha = 1;

                        Thread.Sleep(500);
                        Console.WriteLine("4) Гадюка.");
                        gadyca = 1;
                    }
                    else
                    {
                        karta_mestnosti();
                        belka = 1;
                        gornostai = 1;
                        cheripaha = 1;
                        cat = 1;
                        bot_karta();

                        Thread.Sleep(500);
                        Console.WriteLine("1) Белка.");
                        belka = 1;

                        Thread.Sleep(500);
                        Console.WriteLine("2) Горностай.");
                        gornostai = 1;

                        Thread.Sleep(500);
                        Console.WriteLine("3) Черепаха.");
                        cheripaha = 1;

                        Thread.Sleep(500);
                        Console.WriteLine("4) Кошка.");
                        cat = 1;
                    }

                    int vibor_karti_is_ryk = int.Parse(Console.ReadLine());

                    if (vibor_karti_is_ryk != 1)
                    {
                        Random random = new Random();
                        int fraza3 = random.Next(1, 4);

                        Console.Write("***** - ");

                        string text = "";
                        switch (fraza3)
                        {
                            case 1:
                                text = "Этой карте нужно больше крови.";
                                break;
                            case 2:
                                text = "Этим пока ходить нельзя, но вот белка бесплатная.";
                                break;
                            case 3:
                                text = "Не... но ты можешь пойти белкой.";
                                break;
                        }
                        int time = 100;
                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(time);
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    polozi_karty();
                    if (polozi_carty_mesto == 2)
                    {
                        Console.Write("***** - ");
                        {
                            string fraza = "Ты не можешь положить на это место карту.";
                            int vrema = 100;
                            foreach (char c in fraza)
                            {
                                Console.Write(c);
                                Thread.Sleep(vrema);
                            }
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                zertva_belka_1_3_4();
                vibor_carta();
                vibor_zertvi();
                zertva_belki();
                polozi_karty();

                if (vibor_cart == 1)
                {
                    gornostai_1_3_4();

                    if (polozi_carty_mesto == 1)
                    {
                        gornostai_domage_1();
                    }
                }
                else
                {
                    cat_1_3_4();
                }

            }
            chast1();

            void karta_mestnosti()
            {
                promezytoc1();
                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|         | | камень  | |         | |         |",
                @"|         | |—————————| |         | |         |",
                @"|         | | ___     | |         | |         |",
                @"|         | |│___\_   | |         | |         |",
                @"|         | |│_____\_ | |         | |         |",
                @"|         | |│_______\| |         | |         |",
                @"|         | |—————————| |         | |         |",
                @"|         | |       5 | |         | |         |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '5')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            void polozi_karty()
            {
                Console.Clear();
                promezytoc1();
                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|         | | камень  | |         | |         |",
                @"|         | |—————————| |         | |         |",
                @"|         | | ___     | |         | |         |",
                @"|         | |│___\_   | |         | |         |",
                @"|    1    | |│_____\_ | |    3    | |    4    |",
                @"|         | |│_______\| |         | |         |",
                @"|         | |—————————| |         | |         |",
                @"|         | |       5 | |         | |         |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '1' || c == '3' || c == '4' || c == '5')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.Write("***** - ");
                {
                    string fraza = "Положи карту.";
                    int vrema = 100;
                    foreach (char c in fraza)
                    {
                        Console.Write(c);
                        Thread.Sleep(vrema);
                    }
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }

                polozi_carty_mesto = int.Parse(Console.ReadLine());
            }
            void zertva2()
            {
                bot_karta();

                Console.Write("***** - ");
                {
                    string fraza = "Выбери жертву.";
                    int vrema = 100;
                    foreach (char c in fraza)
                    {
                        Console.Write(c);
                        Thread.Sleep(vrema);
                    }
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }

                karta_zertva2 = int.Parse(Console.ReadLine());
            }
            void zertva1()
            {
                belka = 0;

                Console.Write("***** - ");
                {
                    string fraza = "Выбери жертву.";
                    int vrema = 100;
                    foreach (char c in fraza)
                    {
                        Console.Write(c);
                        Thread.Sleep(vrema);
                    }
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }

                karta_zertva2 = int.Parse(Console.ReadLine());
            }
            void vibor_carta()
            {
                belka = 0;
                bot_karta();

                Console.Write("***** - ");
                {
                    string fraza = "Выбери карту.";
                    int vrema = 100;
                    foreach (char c in fraza)
                    {
                        Console.Write(c);
                        Thread.Sleep(vrema);
                    }
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }

                vibor_cart = int.Parse(Console.ReadLine());
            }
            void pole()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|   | |   | |   | |   | |   | |   | |   | |   |");
                Console.WriteLine(@"|\-------/| |\-------/| |\-------/| |\-------/|");
                Console.WriteLine(@"| \     / | | \     / | | \     / | | \     / |");
                Console.WriteLine(@"|  \   /  | |  \   /  | |  \   /  | |  \   /  |");
                Console.WriteLine(@"|   \_/   | |   \_/   | |   \_/   | |   \_/   |");
                Console.WriteLine(@"——————————— ——————————— ——————————— ———————————");
                Console.ResetColor();
                Thread.Sleep(200);

                string[] lines1 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|  пень   | |         | |  пень   | |         |",
                @"|—————————| |         | |—————————| |         |",
                @"|         | |         | |         | |         |",
                @"| │\_  /│ | |         | | │\_  /│ | |         |",
                @"| │  \/ │ | |         | | │  \/ │ | |         |",
                @"| │_____\ | |         | | │_____\ | |         |",
                @"|—————————| |         | |—————————| |         |",
                @"|       3 | |         | |       3 | |         |",
                @"----------- ----------- ----------- -----------",
                };
                foreach (string line in lines1)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '3')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Thread.Sleep(200);

                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|         | | камень  | |         | |         |",
                @"|         | |—————————| |         | |         |",
                @"|         | | ___     | |         | |         |",
                @"|         | |│___\_   | |         | |         |",
                @"|         | |│_____\_ | |         | |         |",
                @"|         | |│_______\| |         | |         |",
                @"|         | |—————————| |         | |         |",
                @"|         | |       5 | |         | |         |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '5')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

            void vibor_zertvi()
            {
                while (true)
                {
                    zertva_belka_1_3_4();
                    zertva1();

                    if (karta_zertva2 != polozi_carty_mesto)
                    {
                        Console.Write("***** - ");
                        {
                            string fraza = "Это не может стать жертвой.";
                            int vrema = 100;
                            foreach (char c in fraza)
                            {
                                Console.Write(c);
                                Thread.Sleep(vrema);
                            }
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            void zertva_belki()
            {
                promezytoc1();
                zertva_belka_1_3_4();
                Thread.Sleep(1000);
                Console.Clear();
                if (karta_zertva2 == 1)
                {
                    zertva_belka1();
                }
                else if (karta_zertva2 == 3)
                {
                    zertva_belka3();
                }
                else
                {
                    zertva_belka4();
                }
                Thread.Sleep(1000);
                Console.Clear();
                karta_mestnosti();

            }
            void zertva_belka_1_3_4()
            {
                if (polozi_carty_mesto == 1)
                {
                    belka1();
                }
                else if (polozi_carty_mesto == 3)
                {
                    belka3();
                }
                else
                {
                    belka4();
                }
            }

            void gornostai_1_3_4()
            {
                if (polozi_carty_mesto == 1)
                {
                    gornostai1();
                }
                else if (polozi_carty_mesto == 3)
                {
                    gornostai3();
                }
                else
                {
                    gornastai4();
                }
            }
            void gornostai1()
            {
                Console.Clear();
                promezytoc1();
                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|ГОРНОСТАЙ| | камень  | |         | |         |",
                @"|—————————| |---------| |         | |         |",
                @"|         | | ___     | |         | |         |",
                @"| │\———/│ | |│___\_   | |         | |         |",
                @"| │ -_- │ | |│_____\_ | |         | |         |",
                @"|  \_^_/  | |│_______\| |         | |         |",
                @"|—————————| |---------| |         | |         |",
                @"| 1     3 | |       5 | |         | |         |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '5' || c == '3')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            void gornostai_domage_1()
            {
                void gornostai1_domage1_mesto1()
                {
                    string[] lines2 = new string[]
                    {
                @"----------- ----------- ----------- -----------",
                @"|         | | камень  | |         | |         |",
                @"|ГОРНОСТАЙ| |.........| |         | |         |",
                @"|—————————| | ___     | |         | |         |",
                @"|         | |│___\_   | |         | |         |",
                @"| │\———/│ | |│_____\_ | |         | |         |",
                @"| │ o_o │ | |│_______\| |         | |         |",
                @"|  \_^_/  | |.........| |         | |         |",
                @"|—————————| |       5 | |         | |         |",
                @"----------- ----------- ----------- -----------"
                    };
                    foreach (string line in lines2)
                    {
                        foreach (char c in line)
                        {
                            if (c == '|')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            else if (c == '.')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            }
                            else if (c == '5' || c == '3')
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            else if (c == '1')
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (c == '-')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            else if (c == '—')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            Console.Write(c);
                        }
                        Console.ResetColor();
                        Console.WriteLine();
                    } // покраска корт с не живым объектом
                }
                void gornostai1_domage2_mesto1()
                {
                    string[] lines2 = new string[]
                    {
                @"|ГОРНОСТАЙ| ----------- ----------- -----------",
                @"|—————————| | камень  | |         | |         |",
                @"|         | |.........| |         | |         |",
                @"| │\———/│ | | ___     | |         | |         |",
                @"| │ o_o │ | |│___\_   | |         | |         |",
                @"|  \_^_/  | |│_____\_ | |         | |         |",
                @"|—————————| |│_______\| |         | |         |",
                @"| 1     3 | |.........| |         | |         |",
                @"|         | |       5 | |         | |         |",
                @"----------- ----------- ----------- -----------"
                    };
                    foreach (string line in lines2)
                    {
                        foreach (char c in line)
                        {
                            if (c == '|')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            else if (c == '.')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            }
                            else if (c == '5' || c == '3')
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            else if (c == '1')
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (c == '-')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            else if (c == '—')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            Console.Write(c);
                        }
                        Console.ResetColor();
                        Console.WriteLine();
                    } // покраска корт с не живым объектом
                }

                void promezytoc1_domage1_mesto1()
                {
                    string[] lines1 = new string[]
                       {
                @"----------- ----------- ----------- -----------",
                @"|  пень   | |         | |  пень   | |         |",
                @"|......}..| |         | |.........| |         |",
                @"|  }  {  {| |         | |         | |         |",
                @"| {\_} /} | |         | | │\_  /│ | |         |",
                @"|}│ {\/{│ | |         | | │  \/ │ | |         |",
                @"| │}__}_\{| |         | | │_____\ | |         |",
                @"|.}..{..}.| |         | |.........| |         |",
                @"|       3 | |         | |       3 | |         |",
                @"----------- ----------- ----------- -----------",
                       };
                    foreach (string line in lines1)
                    {
                        foreach (char c in line)
                        {
                            if (c == '|')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            else if (c == '.')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            }
                            else if (c == '3')
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            else if (c == '-')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            else if (c == '{' || c == '}')
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            Console.Write(c);
                        }
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }
                void pole_ataca_gornostai_mesto1()
                {
                    void promezytoc()
                    {
                        string[] lines1 = new string[] {
            @"——————————— ——————————— ——————————— ———————————",
            @"|   | |   | |ВОЛЧЁНОК | |   | |   | |   | |   |",
            @"|   | |   | |—————————| |   | |   | |   | |   |",
            @"|   | |   | | │\___/│ | |   | |   | |   | |   |",
            @"|   | |   | | │)o o(│ | |   | |   | |   | |   |",
            @"||———————|| |  \_0_/  | ||———————|| ||———————||",
            @"| |     | | |         | | |     | | | |     | |",
            @"|  |   |  | |—————————| |  |   |  | |  |   |  |",
            @"|   |—|   | | 1  $  l | |   |—|   | |   |—|   |",
            @"——————————— ——————————— ——————————— ———————————",
            };
                        foreach (string line in lines1)
                        {
                            foreach (char c in line)
                            {
                                if (c == '|')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                }
                                else if (c == '—')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                }
                                else if (c == '1')
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                                else if (c == 'l')
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.Write(c);
                            }
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    }
                    void promezytoc1()
                    {
                        string[] lines1 = new string[]
                           {
                @"----------- ----------- ----------- -----------",
                @"|  пень   | |         | |  пень   | |         |",
                @"|.........| |         | |.........| |         |",
                @"|         | |         | |         | |         |",
                @"| │\_  /│ | |         | | │\_  /│ | |         |",
                @"| │  \/ │ | |         | | │  \/ │ | |         |",
                @"| │_____\ | |         | | │_____\ | |         |",
                @"|.........| |         | |.........| |         |",
                @"|       2 | |         | |       3 | |         |",
                @"----------- ----------- ----------- -----------",
                           };
                        foreach (string line in lines1)
                        {
                            foreach (char c in line)
                            {
                                if (c == '|')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else if (c == '.')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                }
                                else if (c == '3' || c == '2')
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }
                                else if (c == '-')
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.Write(c);
                            }
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    }
                    promezytoc();
                    promezytoc1();
                }
                void domage()
                {
                    Thread.Sleep(500);
                    Console.Clear();


                }
                while (true)
                {
                    Console.Clear();
                    promezytoc0();
                    gornostai1();
                    Console.WriteLine("Что бы начать или завершить атаку нажми на Tab");
                    ConsoleKeyInfo keyinfo = Console.ReadKey();

                    if (keyinfo.Key == ConsoleKey.Tab)
                    {
                        domage();
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }

            void gornostai3()
            {
                Console.Clear();
                promezytoc1();
                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|         | | камень  | |ГОРНОСТАЙ| |         |",
                @"|         | |---------| |—————————| |         |",
                @"|         | | ___     | |         | |         |",
                @"|         | |│___\_   | | │\———/│ | |         |",
                @"|         | |│_____\_ | | │ -_- │ | |         |",
                @"|         | |│_______\| |  \_^_/  | |         |",
                @"|         | |---------| |—————————| |         |",
                @"|         | |       5 | | 1     3 | |         |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '5' || c == '3')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            void gornastai4()
            {
                Console.Clear();
                promezytoc1();
                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|         | | камень  | |         | |ГОРНОСТАЙ|",
                @"|         | |---------| |         | |—————————|",
                @"|         | | ___     | |         | |         |",
                @"|         | |│___\_   | |         | | │\———/│ |",
                @"|         | |│_____\_ | |         | | │ -_- │ |",
                @"|         | |│_______\| |         | |  \_^_/  |",
                @"|         | |---------| |         | |—————————|",
                @"|         | |       5 | |         | | 1     3 |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '5' || c == '3')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

            void cat_1_3_4()
            {
                if (polozi_carty_mesto == 1)
                {
                    cat1();
                }
                else if (polozi_carty_mesto == 3)
                {
                    cat3();
                }
                else
                {
                    cat4();
                }
            }
            void cat1()
            {
                Console.Clear();
                promezytoc1();
                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|  КОШКА  | | камень  | |         | |         |",
                @"|---------| |---------| |         | |         |",
                @"| \    /\ | | ___     | |         | |         |",
                @"|  )  ( ')| |│___\_   | |         | |         |",
                @"| (  /  ) | |│_____\_ | |         | |         |",
                @"|  \(__)\ | |│_______\| |         | |         |",
                @"|---------| |---------| |         | |         |",
                @"| 0     1 | |       5 | |         | |         |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '5' || c == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '0')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            void cat3()
            {
                Console.Clear();
                promezytoc1();
                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|         | | камень  | |  КОШКА  | |         |",
                @"|         | |---------| |---------| |         |",
                @"|         | | ___     | | \    /\ | |         |",
                @"|         | |│___\_   | |  )  ( ')| |         |",
                @"|         | |│_____\_ | | (  /  ) | |         |",
                @"|         | |│_______\| |  \(__)\ | |         |",
                @"|         | |---------| |---------| |         |",
                @"|         | |       5 | | 0     1 | |         |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '5' || c == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '0')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            void cat4()
            {
                Console.Clear();
                promezytoc1();
                string[] lines2 = new string[]
                {
                @"----------- ----------- ----------- -----------",
                @"|         | | камень  | |         | |  КОШКА  |",
                @"|         | |---------| |         | |---------|",
                @"|         | | ___     | |         | | \    /\ |",
                @"|         | |│___\_   | |         | |  )  ( ')|",
                @"|         | |│_____\_ | |         | | (  /  ) |",
                @"|         | |│_______\| |         | |  \(__)\ |",
                @"|         | |---------| |         | |---------|",
                @"|         | |       5 | |         | | 0     1 |",
                @"----------- ----------- ----------- -----------"
                };
                foreach (string line in lines2)
                {
                    foreach (char c in line)
                    {
                        if (c == '|')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else if (c == '—')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else if (c == '5' || c == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (c == '0')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (c == '-')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write(c);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            leavel();
        }
    }
}
/*
string[] arr = new string[]
{
    "@", "1", "12221", "aaa"
};

for (int i = 0; i < arr.Length; i++)
{
    if (i==0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(arr[i]);
        arr[2] = arr[i];
        Console.ResetColor();
    }
    else if (i==1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(arr[i]);
        Console.ResetColor();
    }
}
Console.WriteLine(arr[2]);
*/
