namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*davaleba 1
            Console.WriteLine("daweret tqveni useri");
            string user = Console.ReadLine();
            Console.WriteLine("daweret tqveni paroli");
            string pasword = Console.ReadLine();

            if (user == "admin" && pasword == "1234")
            {
                Console.WriteLine("welcome admin");
            }
            else
            {
                Console.WriteLine("invalid user or password");
            }
            */
            /* davaleba 2
            Console.WriteLine("daweret pirveli cifri");
            string Num1Str = Console.ReadLine();
            bool isNum1Valid = int.TryParse(Num1Str, out int Num1);
            Console.WriteLine("daweret operacia");
            string operation = Console.ReadLine();
            Console.WriteLine("daweret meore nomeri");
            string Num2Str = Console.ReadLine();
            bool isNum2Valid = int.TryParse(Num2Str, out int Num2);

            switch (operation)
            {
                case "+":
                    if (isNum1Valid && isNum2Valid)
                    {
                        Console.WriteLine($"result: {Num1 + Num2}");
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                    break;
                case "-":
                    if (isNum1Valid && isNum2Valid)
                    {
                        Console.WriteLine($"result: {Num1 - Num2}");
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                    break;
                case "*":
                    if (isNum1Valid && isNum2Valid)
                    {
                        Console.WriteLine($"result: {Num1 * Num2}");
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                    break;
                case "/":
                    if (isNum1Valid && isNum2Valid)
                    {
                        if (Num2 != 0)
                        {
                            Console.WriteLine($"result: {Num1 / Num2}");
                        }
                        else
                        {
                            Console.WriteLine("cannot divide by zero");
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                    break;
                default:
                    Console.WriteLine("invalid operation");
                    break;
            }
            */
            /* davaleba 3 
            Console.WriteLine("daweret tqveni asaki");
            string ageStr = Console.ReadLine();
            bool isAgeValid = byte.TryParse(ageStr, out byte age);

            if (isAgeValid && age > 0 && age <= 12)
            {
                Console.WriteLine("bovshi");
            } 
            else if (isAgeValid && age <= 19)
            {
                Console.WriteLine("tineijeri");
            }
            else if (isAgeValid && age <= 64)
            {
                Console.WriteLine("zrdasruli");
            }
            else if (isAgeValid && age > 64)
            {
                Console.WriteLine("pensia");
            }
            else if (isAgeValid && age >= 110)
            {
                Console.WriteLine("tkbili dzili");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            */
            
        }
    }
}
