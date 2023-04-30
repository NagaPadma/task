using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    public int input;
    static void Main()
    {
        Console.WriteLine("enter 4 digit number");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("your input is " + input);
        int userInput = input;
        int n = 4;
        
        while (input>0)

        {
            n--;
            int temp = (int)(input / Math.Pow(10, n));
            //Console.WriteLine(temp);

            
            switch (temp )
            {
                case 0:

                    Console.WriteLine(" _ \n| | \n|_|");
                    Console.WriteLine(" ");
                    break;
                case 1:
               
                    Console.WriteLine("   \n  |\n  |");
                    Console.WriteLine(" ");
                    break;
                case 2:
                    Console.WriteLine(" _ \n _|\n|_ ");
                    break;
                case 3:
                    Console.WriteLine(" _ \n _|\n _|");
                    break;
                case 4:
                    Console.WriteLine("   \n|_|\n  |");
                    break;
                case 5:
                    Console.WriteLine(" _ \n|_ \n _|");
                    break;
                case 6:
                    Console.WriteLine(" _ \n|_ \n|_|");
                    break;
                case 7:
                    Console.WriteLine(" _ \n  |\n  |");
                    break;
                case 8:
                    Console.WriteLine(" _ \n|_|\n|_|");
                    break;
                case 9:
                    Console.WriteLine(" _ \n|_|\n _|");
                    break;
            }
            input = (int)(input %Math.Pow(10,n));
        }

        while (true)
        {
            Console.WriteLine("Press Button X for X-axis reflection or Y for Y-axis reflection");

            String Button = Console.ReadLine();

            if (Button == "X")
            {
                invertXaxis(userInput, 4);
            }
            else if (Button == "Y")
            {
                invertYaxis(userInput, 4);
            }
            else break;    
        }

        void invertXaxis(int input, int n)
        {
            while (input > 0)

            {
                n--;
                int temp = (int)(input / Math.Pow(10, n));
                //Console.WriteLine(temp);


                switch (temp)
                {
                    case 0:

                        Console.WriteLine(" _ \n| | \n|_|");
                        Console.WriteLine(" ");
                        break;
                    case 1:

                        Console.WriteLine("   \n  |\n  |");
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.WriteLine(" _ \n|_ \n _|\n");
                        break;
                    case 3:
                        Console.WriteLine(" _ \n _|\n _|\n");
                        break;
                    case 4:
                        Console.WriteLine(" _| \n| | \n  ");
                        break;
                    case 5:
                        Console.WriteLine(" _ \n _|\n|_ \n");
                        break;
                    case 6:
                        Console.WriteLine(" _ \n|_|\n|_\n");
                        break;
                    case 7:
                        Console.WriteLine(" |\n_|\n");
                        break;
                    case 8:
                        Console.WriteLine(" _ \n|_|\n|_|");
                        break;
                    case 9:
                        Console.WriteLine(" _\n _|\n|_| ");
                        break;
                }
                input = (int)(input % Math.Pow(10, n));
            }
        }

            void invertYaxis(int input, int n)
            {
                while (input > 0)

                {
                    n--;
                    int temp = (int)(input / Math.Pow(10, n));
                    //Console.WriteLine(temp);


                    switch (temp)
                    {
                        case 0:

                            Console.WriteLine(" _ \n| | \n|_|");
                            Console.WriteLine(" ");
                            break;
                        case 1:

                            Console.WriteLine("   \n  |\n  |");
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            Console.WriteLine(" _\n|_\n_|");
                            break;
                        case 3:
                            Console.WriteLine(" _\n|_\n|_");
                            break;
                        case 4:
                            Console.WriteLine("|_|\n|\n");
                            break;
                        case 5:
                            Console.WriteLine(" _ \n _|\n|_ ");
                            break;
                        case 6:
                            Console.WriteLine(" _ \n _|\n|_| ");
                            break;
                        case 7:
                            Console.WriteLine(" _\n|\n| ");
                            break;
                        case 8:
                            Console.WriteLine(" _ \n|_|\n|_|");
                            break;
                        case 9:
                            Console.WriteLine(" _\n|_|\n|_");
                            break;
                    }
                    input = (int)(input % Math.Pow(10, n));
                }
            }


        
    }
    
}  

     
