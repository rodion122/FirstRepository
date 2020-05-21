using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            string nameUser;
            nameUser = Console.ReadLine();
            x = Console.ReadLine();
            //Convert.ToDouble(x);
            int key;
            try
            {
                 key = int.Parse(x);
            }  catch(Exception)
            {
                Console.WriteLine(" Ошибка ввода! ");
                key = -1;
            }
            Console.WriteLine("Hello World! " + nameUser + " \t x= " + x + "\n\tkey == " + key);
            Console.ReadKey();

            List <string> list = new List <string>();
            list.Add("Roma");

            List<string> listTwo = new List<string>()  { "Pisa","Gomel","St-Peterdirg","Riga"};

            list.InsertRange(1, listTwo);

            foreach(string i in list)
            Console.WriteLine(i);


            List<string> listikOne = new List<string>();
            List<string> listikTwo = new List<string>();
            int X = 0;
            bool exit = true;
            int chouseNumberList = 0;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine("\t\tMenu:");
                Console.WriteLine("1) Add;");
                Console.WriteLine("2) Show;");
                Console.WriteLine("3) Exit;");
                Console.WriteLine("4) Task;");
                string chouse = Console.ReadLine();
                try
                {
                    X = Convert.ToInt32(chouse);
                }catch(Exception)
                {
                    Console.WriteLine("Error! Not correcter input!");
                    Console.ReadKey();
                }

                switch(X)
                {
                    case 1:
                        Console.WriteLine("Chouse number list:\n1);\n2);\n");
                        try
                        {
                            chouseNumberList = Convert.ToInt32(Console.ReadLine());
                        }catch(Exception)
                        {
                            Console.WriteLine("Fatal ERROR for chouseNumberList!");
                            Console.ReadKey();
                            chouseNumberList = 1;
                        }
                        Console.WriteLine("Input string: ");
                        if( chouseNumberList == 1)
                        listikOne.Add(Console.ReadLine());
                        else
                            listikTwo.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Outup string: ");
                        if( chouseNumberList == 1)
                        foreach(string i in listikOne)
                        {
                            Console.WriteLine(i);
                        }
                        else 
                        {
                            foreach (string i in listikTwo)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        exit = false;
                        Console.WriteLine("Выходим!");
                        Console.ReadKey();
                        listikOne.Clear();
                        listikTwo.Clear();
                        break;

                    case 4:
                        int maxValueForFirstList = 0;
                        int check;
                        foreach (string i in listikOne)
                        {
                            try
                            {
                                check = int.Parse(i);
                            }catch(Exception)
                            {
                                Console.WriteLine("Error for Parse string!");
                                check = 0;
                            }
                                if (check > maxValueForFirstList)
                                maxValueForFirstList = check;
                        }
                        listikOne.InsertRange(maxValueForFirstList, listikTwo);
                        Console.WriteLine("Outpu new ListikOne:");
                        foreach (string i in listikOne)
                            Console.WriteLine(i);
                        Console.ReadKey();
                        break;

                    default:
                      Console.WriteLine("Error! Try again!");
                      Console.ReadKey();
                      break;
                }
            }
        }
    }
}
