using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        public static int MenuOption() {
            string userSelelction="";
            bool selectionFlag = false;
            while (selectionFlag == false)
            {
                Console.WriteLine("1 = Get length");
                Console.WriteLine("2 = Change rectangle length");
                Console.WriteLine("3 = Get width");
                Console.WriteLine("4 = Change rectangle width");
                Console.WriteLine("5 = Calculate Parameter ");
                Console.WriteLine("6 = Calculate Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Please select an option, by entering a number:\n");
                userSelelction = Console.ReadLine();
                if (userSelelction != "1" &&
                    userSelelction != "2" &&
                    userSelelction != "3" &&
                    userSelelction != "4" &&
                    userSelelction != "5" &&
                    userSelelction != "6" &&
                    userSelelction != "7")
                {
                    Console.WriteLine("THis selection is invalid please enter the correct option form the menu:");

                }
                else { selectionFlag = true; }
            }

            return int.Parse(userSelelction);
        }
        /*
        public static Rectangle DimensionsValidation()
        {
            bool valid = false;
            string length, width;
            double lengthNumber=1, widthNumber=1;
            while (valid == false)
            {
                Console.WriteLine("Provide Diemensions length and width of the rectangle.");
                Console.WriteLine("Enter length of the rectangle");
                length = Console.ReadLine();
                Console.WriteLine("Enter width of the rectange");
                width = Console.ReadLine();
                if(!double.TryParse(length, out lengthNumber) ||
                    !double.TryParse(width, out widthNumber))
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }
                else
                {
                    if (lengthNumber < 1 && widthNumber < 1)
                    {
                        Console.WriteLine("That's not a valid input please, enter the value above 1.\n");
                    }
                    else {
                        valid = true;
                        Console.WriteLine($"Your Length has been set to: {lengthNumber}.\n");
                        Console.WriteLine($"Your width has been set to: {widthNumber}.\n");
                        
                    }
                }
            }
            Rectangle recObj = new Rectangle(lengthNumber, widthNumber);
            return recObj;


        }
        */

        public static double ValidateUserInput(string chosenDimension)
        {
            double aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {chosenDimension}:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = double.TryParse(userInput, out aNumber);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please,  try again.\n");
                }

                else
                {
                    isValid = true;
                    Console.WriteLine($"Current {chosenDimension} has been changed to: {aNumber}.\n");
                }
            }

            return aNumber;
        }


        public static void Main(string[] args)
        {
            Rectangle rectangleObj = new Rectangle();
          
            int selection;
            double length, width;
           

            length = ValidateUserInput("Length");
            width = ValidateUserInput("Width");


            Console.WriteLine($"Entered dimentions are length: {length} and width: {width}.\n");
            Rectangle rectObj = new Rectangle(length, width);
            rectangleObj=rectObj;

            selection = MenuOption();

            while (selection != 7)
            {
                double result;

                switch (selection)
                {
                    case 1:
                        {
                            Console.WriteLine($"Length is :{rectangleObj.GetLength()}\n");
                            break;
                        }
                    case 2:
                        {
                            result = ValidateUserInput("Length");
                            rectangleObj.SetLength(result);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Length is :{rectangleObj.GetWidth()}\n");
                            break;
                        }
                    case 4:
                        {
                            result = ValidateUserInput("Width");
                            rectangleObj.SetLength(result);
                            break;
                        }
                    case 5:
                        Console.WriteLine($"The paremeter of the rectangle is calculated to be: {rectangleObj.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The area is :  {rectangleObj.GetArea()}\n");
                        break;
                    default:
                        break;
                }

                selection = MenuOption();
            }            
        }
    }
}
