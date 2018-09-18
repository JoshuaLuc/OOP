using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            string checknum;
            int a = 0;
            int SqrLength;
            string CheckNumber;
            string SqrColour;
            int RecLength;
            int RecHeight;
            string RecColour;



            bool keepLooping = true;

            while (keepLooping == true)
            {



                Console.WriteLine("1 for square");
                Console.WriteLine("2 for rectangle");
                Console.WriteLine("3 to exit");


                try
                {
                    checknum = Console.ReadLine();
                    choice = checknum;
                    int number;
                    bool isnum = int.TryParse(checknum, out number);
                    if (!isnum)
                    {
                        throw new isnotint();
                    }


                }
                catch (isnotint x)
                {
                    Console.WriteLine(x.Message);
                    Console.WriteLine("");
                    


                }


                switch (choice)
                {




                    case "1":
                        {
                            Console.WriteLine("Please enter a colour:");
                            SqrColour = Console.ReadLine();
                            Console.WriteLine("Please enter length:");
                            try
                            {
                                CheckNumber = Console.ReadLine();
                                int Number;
                                bool isNumber = int.TryParse(CheckNumber, out Number);
                                if (!isNumber)
                                {
                                    throw new isnotint();
                                }
                                else
                                {
                                    SqrLength = Convert.ToInt32(CheckNumber);

                                    try
                                    {
                                        if (SqrLength < 1)
                                        {
                                            throw new isLessThanOne();
                                        }
                                        else
                                        {

                                            Square Square = new Square(SqrColour, SqrLength);
                                            Console.WriteLine("Square;   " + "Color = " + SqrColour + " Length = " + SqrLength + " Area = " + SqrLength * SqrLength + " Perimerter = " + SqrLength * 4);

                    
                                            break;

                                        }
                                    }
                                    catch (isLessThanOne x)
                                    {
                                        Console.WriteLine(x.Message);
                                        Console.WriteLine("");
                                        break;
                                    }
                                }
                            }
                            catch (isnotint x)
                            {
                                Console.WriteLine(x.Message);
                                Console.WriteLine("");
                                break;
                            }
                        }




                    case "2":
                        {
                            Console.WriteLine("Please enter a colour:");
                            RecColour = Console.ReadLine();
                            Console.WriteLine("Please Input Length");
                            try
                            {
                                CheckNumber = Console.ReadLine();
                                int Number;
                                bool isNumber = int.TryParse(CheckNumber, out Number);
                                if (!isNumber)
                                {
                                    throw new isnotint();
                                }
                                else
                                {
                                    RecLength = Convert.ToInt32(CheckNumber);

                                    try
                                    {
                                        if (RecLength < 1)
                                        {
                                            throw new isLessThanOne();
                                        }
                                        else
                                        {

                                        }
                                    }
                                    catch (isLessThanOne x)
                                    {
                                        Console.WriteLine(x.Message);
                                        Console.WriteLine("");
                                        break;
                                    }
                                }
                            }
                            catch (isnotint x)
                            {
                                Console.WriteLine(x.Message);
                                Console.WriteLine("");
                                break;
                            }
                            Console.WriteLine("Please Input Height");
                            try
                            {
                                CheckNumber = Console.ReadLine();
                                int Number;
                                bool isNumber = int.TryParse(CheckNumber, out Number);
                                if (!isNumber)
                                {
                                    throw new isnotint();
                                }
                                else
                                {
                                    RecHeight = Convert.ToInt32(CheckNumber);

                                    try
                                    {
                                        if (RecHeight < 1)
                                        {
                                            throw new isLessThanOne();
                                        }
                                        else
                                        {

                                        }
                                    }
                                    catch (isLessThanOne x)
                                    {
                                        Console.WriteLine(x.Message);
                                        Console.WriteLine("");
                                        break;
                                    }
                                }
                            }
                            catch (isnotint x)
                            {
                                Console.WriteLine(x.Message);
                                Console.WriteLine("");
                                break;
                            }
                            int per = RecHeight * 2 + RecLength * 2;
                            int recarea = RecHeight * RecLength;
                            Rectangle Rectangle = new Rectangle(RecColour, RecLength, RecHeight);
                            Console.WriteLine("Rectangle;   " + "Color = " + RecColour + " Length = " + RecLength + " Area = " + recarea + " Perimerter = " + per);


                            break;
                        }



                    case "3":
                        {
                            keepLooping = false;
                            break;
                        }


                }

            }



            Console.WriteLine("GoodBye");
            Console.ReadLine();
        }



    }
}

    class isnotint : Exception
    {
        public isnotint() : base("Input is not a number, Returning to Menu")
            {

            }
    }

class isLessThanOne : Exception
{
    public isLessThanOne() : base("Input can not be less than 1, Returning to Menu")
    {

    }
}





