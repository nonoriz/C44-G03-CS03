namespace demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region fraction and discard
            //float myFloat = 10.123456789f;
            //// The float type has limited precision, so it may not store all decimal places accurately
            //Console.WriteLine( myFloat); // Output:  10.123457 rounded the last digit 

            //double myDouble = 10.123456789123456789;
            //Console.WriteLine(myDouble); // Output: 10.123456789123457, double rounded 

            //decimal myDecimal = 10.123456789123456789m;
            //Console.WriteLine(myDecimal); // Output: 10.123456789123456789, decimal stores all digits accurately

            //long number = 10_000_0000_0000; // Using underscores for better readability
            //Console.WriteLine($"{number:c}"); // Output: 10,000,000,000.00 (currency format)

            //CultureInfo culture = new CultureInfo("ar-SA");
            //Console.WriteLine(number.ToString("C", culture)); // saudi reyals


            #endregion

            #region casting 
            #region implicit and explicit casting
            #region example01
            //int x = 1000; // 4 bytes
            //long y = x; //8 bytes 
            //// Implicit casting from int to long (no data loss)
            //Console.WriteLine(y); // Output: 1000

            //long a = 100000000; // 8 bytes
            //// int b = a; //invalid 
            //int b = (int)a; // Explicit casting from long to int (possible data loss)
            // Console.WriteLine(b); // Output: 10000

            //checked
            //{
            //    int b = (int)a; // system.OverflowException if a is too large for int
            //    unchecked
            //    {
            //        Console.WriteLine(b); //1410065408 ==> due to overflow
            //    }
            //}


            /// protetive code
            //long k = 100000000000;
            //if (k > int.MaxValue || k < int.MinValue)
            //{
            //    Console.WriteLine("Exception will be throwen.");
            //}
            //else
            //{
            //    int m = (int)k; // Safe explicit casting
            //    Console.WriteLine(m);
            //}

            //object number = 10000000000000000;

            //int x=number.GetType()== typeof(int) ? (int)number : 0; // Safe explicit casting with type check

            //int result = x+10; 
            //Console.WriteLine(result);
            #endregion
            #region example02
            //int x= 10;
            //float y = x;
            //Console.WriteLine(Y)
            //decimal a = 10.1000m;
            //int b = (int)a; // Explicit casting - unsafe casting [may be cause loss of data]
            //Console.WriteLine(b); // Output: 10 (decimal to int conversion truncates the decimal part)

            #endregion

            #endregion

            #region convert
            // we can use convert if i sure that i will enter a valid string 
            //Console.WriteLine("hello blease enter your data :");
            //Console.Write("name : ");
            //string? name = Console.ReadLine();

            //Console.Write("age : ");
            //int age =Convert.ToInt32(Console.ReadLine());   // Convert.ToInt32() is a method that converts a value to a 32-bit signed integer.
            //// It can handle various types of input, including strings, and will throw an exception if the conversion fails.

            //Console.Write("salary : ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine()); // Convert.ToDecimal() is a method that converts a value to a decimal type.


            //Console.Clear(); // Clear the console for better readability


            //Console.WriteLine("===============================");
            //Console.WriteLine("employee data : ");
            //Console.WriteLine("===============================");

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("salary : " + salary);

            #endregion

            #region parse()

            //Console.WriteLine("hello blease enter your data :");
            //Console.Write("name : ");
            //string? name = Console.ReadLine();

            //Console.Write("age : ");
            //int age =int.Parse(Console.ReadLine() ?? "0");   // int.Parse() is a method that converts a string representation of a number to its 32-bit signed integer equivalent.

            //Console.Write("salary : ");
            //decimal salary = decimal.Parse(Console.ReadLine() ?? "0"); // decimal.Parse() is a method that converts a string representation of a number to its decimal equivalent.

            //Console.Clear(); // Clear the console for better readability


            //Console.WriteLine("===============================");
            //Console.WriteLine("employee data : ");
            //Console.WriteLine("===============================");

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("salary : " + salary);
            #endregion

            #region TryParse()
            //string number01 = "10";
            //int x01 = int.Parse(number01);
            //Console.WriteLine(x01);

            ////string number02 = "Aliaa";
            ////int x02=int.Parse(number02);
            ////Console.WriteLine(x02); // This will throw an exception because "Aliaa" cannot be parsed as an integer.
            //// system.FormatException

            //string number02 = "Aliaa";
            //bool isParse= int.TryParse(number02, out int x02);
            //Console.WriteLine(isParse); // Output: False
            //Console.WriteLine(x02); // Output: 0, because "Aliaa" cannot be parsed as an integer, and TryParse returns false without throwing an exception.
            //// isParsed => True , x02= value
            //// isParsed => False , x02= 0

            //Console.WriteLine("hello blease enter your data :");
            //Console.Write("name : ");
            //string? name = Console.ReadLine();

            //Console.Write("age : ");
            //// int age = int.Parse(Console.ReadLine() ?? "0");
            //int.TryParse(Console.ReadLine(), out int age);

            //Console.Write("salary : ");
            //// decimal salary = decimal.Parse(Console.ReadLine() ?? "0");
            //decimal.TryParse(Console.ReadLine(), out decimal salary);


            //Console.Clear(); // Clear the console for better readability


            //Console.WriteLine("===============================");
            //Console.WriteLine("employee data : ");
            //Console.WriteLine("===============================");

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("salary : " + salary);

            #endregion

            #endregion

            #region operators
            #region unaryOperators[++ , --]
            //int x = 10;
            // 1. ++
            //1.1 prefix [increment and then print ]
            //Console.WriteLine(++x); //11
            //Console.WriteLine(x); //11

            ////1.2 postfix [print and then increment ]
            //Console.WriteLine(x++); //10
            //Console.WriteLine(x); //11

            // 2. --
            // 2.1 prifix [decrement and then print ]
            //Console.WriteLine(--x);//9
            //Console.WriteLine(x); // 9

            //// 2.2 postfix [print and then decrement ]
            //Console.WriteLine(x--); //10
            //Console.WriteLine(x); //9

            #endregion

            #region Binary | Arithmetic operators[+ , - ,*,/ , % ]

            //int sumResult ,subResult, mulResult, divResult, modResult;
            //int number01 = 6, number02 = 2;
            //sumResult= number01 + number02; // 8
            //subResult= number01 - number02; // 4
            //mulResult= number01 * number02; // 12
            //divResult= number01 / number02; // 3
            //modResult= number01 % number02; // 0

            #endregion

            #region Assignment operators [= , += , -= , *= , /= , %= ]
            //int x;
            //x = 4;
            //x+= 2; // x = x + 2; 
            //x -= 2; // x = x - 2; 
            //x*= 2; // x = x * 2; 
            //x /= 2; // x = x / 2; 
            //x%= 2; // x = x % 2; 

            #endregion

            #region Relational | comparsion operators [ ==, != , >= , <= , < , > ]
            //int x = 10, y = 9;

            //Console.WriteLine(x==y); // false
            //Console.WriteLine(x!=y); // true
            //Console.WriteLine(x>=y); // true
            //Console.WriteLine(x<=y); // false
            //Console.WriteLine(x>y); // true
            //Console.WriteLine(x<y); // false

            #endregion

            #region Logical operators [! , && , || ]
            //// short circuits 
            //Console.WriteLine(!true); // false
            //Console.WriteLine(false && true); // false
            //// true && false => false
            //// true && true => true
            //// false && false => false
            //// false && true => false


            //Console.WriteLine(false || true); // true
            //// true || false => true
            //// true || true => true
            //// false || false => false
            //// false || true => true

            //Console.WriteLine(4<5 && 7<9); // true
            //Console.WriteLine(4<5 || 7>9); // true
            //Console.WriteLine(4<5 && 7>9); // false
            //Console.WriteLine(4<5 || 7<9); // true

            #endregion

            #region Bitwise operators [ & , | , ^ , ~ , << , >> ]
            //// long circuits 
            //Console.WriteLine(false & true); // false
            //Console.WriteLine(true | false); // true
            //Console.WriteLine(true ^ false); // true



            //int x = 5, y = 3; // 5 = 0101 in binary, 3 = 0011 in binary
            //Console.WriteLine( x & y);// 0001
            //Console.WriteLine( x | y); // 0111 ==> 7
            //Console.WriteLine( x ^ y);// 0110 ==> 6
            //Console.WriteLine(~x); // 1010 ==> -6 (compliment of x)
            //Console.WriteLine(x <<1); // 1010==>10 (left shift)
            //Console.WriteLine( x >> 1); // 0010 ==> 2 (right shift)

            #endregion

            #region Ternary operators [?:]
            //int x = 10, y = 5;
            //string message = x > y ? " x > y" : " x < y";
            //Console.WriteLine(message); // Output: " x > y" because 10 is greater than 5

            #endregion

            #region operators piriority and associativity

            //int a=20, b=15 , c=10, d=5 , result;
            //result = (a + b) * c / d; //70
            //result = ((a+ b) * d) / c; //30
            //result = (a + b) * (c / d); // 60
            //result = a + (b * c) / d; // 55
            //result = a + b++; // 35
            //result = a + ++b; // 36
            //result = a + b++ + b; // 20 +15 + 16 = 51



            #endregion
            #endregion

            #region string formatting
            //// equation : 10+ 5=15

            //int x = 10, y = 5;
            //int result = x + y;
            //string message;
            //// 1. string interpolation
            // message = $"equation : {x} + {y} = {result}";
            //Console.WriteLine(message); // Output: equation : 10 + 5 = 15

            ////2. string.format method
            //message = string.Format("equation : {0} + {1} = {2}", x, y, result);
            //Console.WriteLine(message); // Output: equation : 10 + 5 = 15

            ////3.composite formatting
            //Console.WriteLine("equation : {0} + {1} = {2}", x, y, result); // Output: equation : 10 + 5 = 15

            ////4, string concatenation
            //message = "equation : " + x + " + " + y + " = " + result;
            ////equation :
            ////equation : 10
            ////equation : 10 +
            ////equation : 10 + 5
            ////equation : 10 + 5 = 
            ////equation : 10 + 5 = 15
            //Console.WriteLine(message); // Output: equation : 10 + 5 = 15


            #endregion

            #region control statements

            #region 1.conditional statements
            #region Example01 [year quarter] -[if ,switch with numeric types using constant pattern]
            //int.TryParse(Console.ReadLine(), out int monthNumber);
            #region if-statement
            //if (monthNumber == 1)
            //{
            //    Console.WriteLine("hello January");
            //}else if (monthNumber == 2)
            //{
            //    Console.WriteLine("hello February");
            //}else if (monthNumber == 3)
            //{
            //    Console.WriteLine("hello March");
            //}else
            //{
            //    Console.WriteLine("the entered month number is invalid month in the first quarter ");
            //}

            #endregion

            #region switch-statement
            // jump table will be generated by compiler at compilation time  ==>number and conatant value 
            //switch(monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("hello January");
            //        break;
            //    case 2:     
            //        Console.WriteLine("hello February");
            //        break;
            //    case 3:
            //        Console.WriteLine("hello March");
            //        break;
            //    default:
            //        Console.WriteLine("the entered month number is invalid month in the first quarter ");
            //        break;

            //}
            //#endregion

            #endregion

            #endregion

            #region Example02 [student age ] - [if ,switch with numeric types using constant pattern]
            /// age is greater than 22 ==> student age is greater than 22
            /// age is less than 22 ==> student age is less than 22
            /// age is equal to 22 ==> student age is equal to 22
            //Console.WriteLine("please enter your age :");
            //int.TryParse(Console.ReadLine(), out int age);

            #region if-statement
            //if(age> 22)
            //{
            //    Console.WriteLine("student age is greater than 22");
            //}
            //else if (age < 22)
            //{
            //    Console.WriteLine("student age is less than 22");
            //}
            //else 
            //{
            //    Console.WriteLine("student age is equal to 22");
            //}

            #endregion

            #region switch-statement
            //switch (age)
            //{
            //    case > 22:
            //        Console.WriteLine("student age is greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("student age is less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("student age is equal to 22");
            //        break;

            //}

            #endregion

            #endregion

            #region Example03 [student name ] - [if ,switch with string types using constant pattern]
            /// name Omar ==> hello Omar
            /// name Aliaa ==> hello Aliaa
            /// name Ahmed ==> hello Ahmed

            //Console.WriteLine("enter student name :");
            //string name = Console.ReadLine() ?? "no name founded ";
            #region if-statement
            //if (name == "Omar")
            //{
            //    Console.WriteLine("hello Omar");
            //}else if (name == "Aliaa")
            //{
            //    Console.WriteLine("hello Aliaa");
            //}
            //else if (name == "Ahmed")
            //{
            //    Console.WriteLine("hello Ahmed");
            //}


            #endregion

            #region switch-statement
            // no jump table will be created 
            // compiler will create a sequence of if-else statements
            //switch (name)
            //{
            //    case "Omar":
            //        Console.WriteLine("hello Omar");
            //        break;
            //    case "Aliaa":
            //        Console.WriteLine("hello Aliaa");   
            //        break;
            //    case "Ahmed":
            //        Console.WriteLine("hello Ahmed");
            //        break;
            //}

            #endregion
            #endregion

            #region Example04 [budget] - [if ,switch with string types using constant pattern]
            /// budget is 1000 ==> option01
            /// budeget is 2000 ==> option01,option02
            /// budget is 3000 ==> option01,option02,option03
            //Console.WriteLine("please enter your budget :");
            //int.TryParse(Console.ReadLine(), out int budget);

            #region GoTo
            //Retry:
            //    Console.WriteLine("hello hamada");


            //Console.WriteLine("enter your name :");
            //string? name = Console.ReadLine();

            //if (name == "hamada")
            //    {
            //        goto Retry;
            //    }else
            //    {
            //        Console.WriteLine("hello " + name);
            //    }


            #endregion

            #region switch-statement
            //switch (budget)
            //{
            //    case 1000:
            //        Console.WriteLine("option01");
            //        break;
            //    case 2000:

            //        Console.WriteLine("option02");
            //        goto case 1000;

            //    case 3000:
            //        Console.WriteLine("option03");
            //        goto case 2000;
            //}
            #endregion

            #endregion

            #endregion


            #endregion

        }
    }
}
