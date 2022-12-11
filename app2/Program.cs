using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

namespace app2
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)


        // Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tap
        //{
        //    Console.WriteLine("Ededleri daxil edin");
        //    var inputM = Console.ReadLine();
        //    var numM = Convert.ToInt32(inputM);
        //    var inputN = Console.ReadLine();
        //    var numN = Convert.ToInt32(inputN);
        //    var sum = 0;
        //    var count = 0;
        //    for (int i = numM; i < numN; i++)
        //    {
        //        if (i % 21 == 0)
        //        {
        //            sum += i;
        //            count++;
        //        }
        //    }

        //    if (count != 0)
        //    {
        //        var avg = sum / count;
        //        Console.WriteLine(avg);
        //    }
        //    else
        //    {
        //        Console.WriteLine("0-a bolme yoxdur");
        //    }


        //Verilmiş ədədin rəqəmləri cəmini tap

        {
            Console.WriteLine("Ededi daxil et");
            var input = Console.ReadLine();
            var N = Convert.ToInt32(input);
            var input21 = Console.ReadLine();
            var X = Convert.ToInt32(input21);
            var sum1 = 0;
            {
                {


                    while (N != 0)

                        X = N % 10;
                }
                {
                    if
                         (0 == ((N - X) / 10))
                        sum1 = sum1 + X;
                    Console.WriteLine(sum1);
                }
         




            }
            // Verilmiş ayın ədədinə görə hansı fəsil olduğunu tap
            Console.WriteLine("Ededi daxil et");
            var input0 = Console.ReadLine();
            var month = Convert.ToInt32(input0);
            var input1 = Console.ReadLine();
            var spring = Convert.ToInt32(input1);
            var input2 = Console.ReadLine();
            var summer = Convert.ToInt32(input2);
            var input3 = Console.ReadLine();
            var fall = Convert.ToInt32(input3);
            var input4 = Console.ReadLine();
            var winter = Convert.ToInt32(input4);
            if (month >= 3 && month <= 5)
                Console.WriteLine(spring);
            else if (month >= 6 && month <= 8)
                Console.WriteLine(summer);
            else if (month >= 9 && month <= 11)
                Console.WriteLine(fall);
            else
                Console.WriteLine(winter);

            {

            }

        }

    }
    


}


        





