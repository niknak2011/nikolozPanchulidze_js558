namespace HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* proj 1
            Console.WriteLine("chaweret tqveni asaki");

            string ageSTR = Console.ReadLine();
            bool ageIsNumber = byte.TryParse(ageSTR, out byte age);

            if (ageIsNumber) 
            {
                if (age > 100)
                {
                    Console.WriteLine("invalid input");
                }
                else if (age < 18)
                {
                    Console.WriteLine("samwuxarod ar shegidzliat xmis micema.");   
                }
                else
                {
                    Console.WriteLine("gilocavt xmis micema shegidzliat");
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            */
            /* proj 2
            Console.WriteLine("write 3 numbers");
            Console.WriteLine("number 1");
            string Number1String = Console.ReadLine();
            Console.WriteLine("number 2");
            string Number2String = Console.ReadLine();
            Console.WriteLine("number 3");
            string Number3String = Console.ReadLine();

            bool Number1IsNumber = int.TryParse(Number1String, out int Number1);
            bool Number2IsNumber = int.TryParse(Number2String, out int Number2);
            bool Number3IsNumber = int.TryParse(Number3String, out int Number3);

            if (Number1IsNumber && Number2IsNumber && Number3IsNumber)
            {
               if (Number1 > Number2 && Number1 > Number3)
               {
                  Console.WriteLine("number 1 is the biggest number");
               }
               else if (Number2 > Number1 && Number2 > Number3)
               {
                  Console.WriteLine("number 2 is the biggest number");
               }
               else if (Number3 > Number1 && Number3 > Number2)
               {
                  Console.WriteLine("number 3 is the biggest number");
               }

            }
            else
            {
                Console.WriteLine("invalid input");
            }
            */

            Console.WriteLine("dawere ori mteli ricxvi");

            string Number11String = Console.ReadLine();
            string Number22String = Console.ReadLine();

            bool Number11IsNumber = int.TryParse(Number11String, out int Number11);
            bool Number22IsNumber = int.TryParse(Number22String, out int Number22);

            if (Number11IsNumber && Number22IsNumber) 
            {
               if (Number11 == Number22)
                {
                    Console.WriteLine((Number11+Number22)*3);
                }
               else
                {
                    Console.WriteLine(Number11 + Number22);
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }




        }
    }
}
