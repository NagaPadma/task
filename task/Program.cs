using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    public int input;
    static int getDigitLength(int userInput)
    {
        int count = 0;
        while (userInput > 0)
        {
            count++;
            userInput = userInput / 10;
        }
        return count;
    }

    static void invertXaxis(int input, int n)
    {
        while (input > 0)
        {
            int temp = (int)(input / Math.Pow(10, --n));
            switch (temp)
            {
                case 0:
                    Console.WriteLine(" _ \n| | \n|_|");
                    break;
                case 1:
                    Console.WriteLine("   \n  |\n  |");
                    break;
                case 2:
                    Console.WriteLine(" _ \n|_ \n _|");
                    break;
                case 3:
                    Console.WriteLine(" _ \n _|\n _|\n");
                    break;
                case 4:
                    Console.WriteLine("\n _|\n| |");
                    break;
                case 5:
                    Console.WriteLine(" _ \n _|\n|_ ");
                    break;
                case 6:
                    Console.WriteLine(" _\n|_|\n|_");
                    break;
                case 7:
                    Console.WriteLine(" |\n_|\n");
                    break;
                case 8:
                    Console.WriteLine(" _ \n|_|\n|_|");
                    break;
                case 9:
                    Console.WriteLine(" _\n _|\n|_|");
                    break;
            }
            input = (int)(input % Math.Pow(10, n));
        }
    }

    static void invertYaxis(int input, int n)
    {
        while (input > 0)
        {
            int temp = (int)(input / Math.Pow(10, --n));
            switch (temp)
            {
                case 0:
                    Console.WriteLine(" _ \n| | \n|_|");
                    break;
                case 1:
                    Console.WriteLine("   \n  |\n  |");
                    break;
                case 2:
                    Console.WriteLine(" _ \n|_ \n _|");
                    break;
                case 3:
                    Console.WriteLine(" _\n|_\n|_");
                    break;
                case 4:
                    Console.WriteLine("\n|_|\n|");
                    break;
                case 5:
                    Console.WriteLine(" _ \n _|\n|_ ");
                    break;
                case 6:
                    Console.WriteLine(" _\n _|\n|_|");
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

    static void convertToDigitalFormat(int input, int n)
    {
        while (input > 0)
        {
            int temp = (int)(input / Math.Pow(10, --n));
            switch (temp)
            {
                case 0:
                    Console.WriteLine(" _ \n| | \n|_|");
                    break;
                case 1:
                    Console.WriteLine("   \n  |\n  |");
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
            input = (int)(input % Math.Pow(10, n));
        }
    }


    static void Main()
    {
        Console.WriteLine("Hi, Please enter 4 digit number");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Entered number is " + input);
        int userInput = input;
        int DigitLength = getDigitLength(userInput); //to get the count of the numbers entered by the user
        if (DigitLength <= 4)  // allow only if the entered digit length is less than or equal to 4
        {
            convertToDigitalFormat(input, 4); //this would display the entered number to digital format
            while (true) // this would run infintely for button X and Y and would terminate if other keys are pressed.
            {
                Console.WriteLine("Press Button X for X-axis reflection or Y for Y-axis reflection");
                String Button = Console.ReadLine();
                if (Button == "X") invertXaxis(userInput, 4); // invert the given input with respect to X-axis
                else if (Button == "Y") invertYaxis(userInput, 4); // invert the given input with respect to Y-axis
                else break;
            }
        }
        else { Console.WriteLine("Please pass the input less than or equal to 4"); } // throw error if the entered input length is greater than 4
    }
}