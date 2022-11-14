using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");





            //int age = 10;

            //if (age >= 12)
            //{
            //    Console.WriteLine("10 boyuk deyl");

            //}





            //else if (age <= 12)
            //{
            //    Console.WriteLine("12 boyukdur");
            //}
            //string ad = "Elchin";
            //switch (ad)
            //{
            //    case "Mustafa":
            //        Console.WriteLine("Adi Mustafa");
            //        break;

            //    case "Elchin":
            //        Console.WriteLine("Adi Elchin");
            //        break;

            //    case "Ilqar":
            //        Console.WriteLine("Adi Ilgar");
            //        break;
            //    case "Mehman":
            //        Console.WriteLine("Adi Mehman");
            //        break;
            //}





            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //int number = 50;

            //while (number < 0)
            //{
            //    Console.WriteLine(number);

            //}





            //var student = new
            //{
            //    firstname = "Cemil",
            //    surname = "Isaev",
            //    age = 23

            //};
            //Console.WriteLine(student.firstname);









            //string[] student_name = { "Elcin", "Abbasov", "Xicran" };

            //for (int i = 0; i < student_name.Length; i++)
            //{
            //    Console.WriteLine(student_name[i]);
            //}

            //int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 1, 2 } };

            //Console.WriteLine(numbers[1, 1]);







            //Console.WriteLine("Please choose number");
            //string num = Console.ReadLine();

            //Console.WriteLine("Choose number: " + num);







            //Console.WriteLine("Please choose number");

            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Result: ");

            //if (num % 4 == 0 && num % 9 == 0)
            //{
            //    Console.Write("Bolunur");
            //}

            //else
            //{
            //    Console.Write("Bolunmur");
            //}





            //Console.WriteLine("Bir eded secin");
            //string numStr = Console.ReadLine();
            //int n = Convert.ToInt32(numStr);

            //while (n % 2 == 0)
            //{
            //    n /= 2;
            //}
            //if (n == 1)
            //{
            //    Console.WriteLine("Quvetidir");
            //}
            //else
            //{
            //    Console.WriteLine("Quveti deyl");
            //}







            //#region
            //Console.WriteLine("Bir eded daxil edin");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir ededi daxil edin");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = num1; i < num2; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //#endregion






            // #region
            // Console.WriteLine("Bir eded daxil edin");
            // int num = Convert.ToInt32(Console.ReadLine());
            // int i = 70;
            // if (num > i) 
            // {
            //     num = num - i;
            //     num *= 3;
            // }
            // else
            // {
            //     num -= i;
            // }
            // Console.WriteLine(num);
            //}
            // #endregion





            //#region
            //int x = 20;
            //int y = 30;
            //int z = 40;

            //if (x > y && x > z)
            //{
            //    Console.WriteLine(x);
            //}
            //else if (y > x && y > z)
            //{
            //    Console.WriteLine(y);
            //}
            //else
            //{
            //    Console.WriteLine(z);
            //}
            //#endregion


            #region
            Console.WriteLine("N ededini daxil edin");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m ededini daxil edin");
            int m = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            if (n % 2 == 0)
            {
                n++;
            }

            for (int i = n; i <= m; i+=2)
            {
                count++;
            }
            Console.WriteLine(count);
            #endregion






        }

    }
}




      
        