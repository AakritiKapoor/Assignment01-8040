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
            }
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

            return int.Parse(userSelelction);
        }
        
        
        
        static void Main(string[] args)
        {
            Rectangle rectengleObj = new Rectangle();
            bool selectionFlag = false;
            string length, width;
            double lengthNumber, widthNumber;

            do {
                Console.WriteLine("Enter length of the rectangle");
                length = Console.ReadLine();
                Console.WriteLine("Enter width of the rectange");
                width = Console.ReadLine();
            }
            while (!double.TryParse(length, out lengthNumber)||
            ! double.TryParse(width,out widthNumber));
        }
    }
}
