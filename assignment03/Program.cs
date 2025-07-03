namespace assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Write a program that allows the user to enter a number then print it
            //Console.Write("enter a number : ");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine("you entered : " + number);
            #endregion
            #region Q2
            //Write C# program that converts a string to an integer, but the string contains non-numeric characters.
            //And mention what will happen
            //string str = "nour";

            //int.TryParse(str, out int number);
            //Console.WriteLine("The converted number is: " + number); //0 ==> can't be parsed to an integer ,
            //it will return 0 without throwing an exception



            #endregion

            #region Q3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            // float number1 = 2.12345678f; //// The float type has limited precision (7) digits after the decimal point,
            //// it will round the  last digit
            //float number2 = 5.52213234f; // will occur the same here
            //float result = number1 + number2;
            //Console.WriteLine("result = " + result);
            // The output will be 7.645589f, the last digit is rounded because of the limited precision of float type
            #endregion

            #region Q4
            //Write C# program that Extract a substring from a given string.
            //string str = "Hello, programmer";
            //string substring = str.Substring(0, 5);
            //Console.WriteLine("substring is : " + substring);
            #endregion

            #region Q5
            //Write C# program that Assigning one value type variable to another and modifying the
            //value of one variable and mention what will happen
            //int number1 = 10;
            //int number2 = number1;
            //number2 = 5;
            //Console.WriteLine("number1 = " + number1); // number1 will still be 10
            //Console.WriteLine("number2 = " + number2); // number2 will be 5
            // the reason is that value types are stored in stack memory, and when we assign number1 to number2,
            // a copy of the value is made.
            #endregion

            #region Q6
            //Write C# program that Assigning one reference type variable
            //to another and modifying the object through one variable and mention what will happen
            //mySolution6 obj1= new mySolution6();
            //obj1.num = 10;
            //mySolution6 obj2 = obj1; // obj2 now references the same object as obj1
            //obj2.num = 20; // modifying the object through obj2
            //Console.WriteLine("obj1.num = " + obj1.num); // obj1.num will be 20
            //Console.WriteLine("obj2.num = " + obj2.num); // obj2.num will also be 20
            // the reason is that reference types are stored in heap memory, and when we assign obj1 to obj2,


            #endregion

            #region Q7
            //Write C# program that take two string variables and print them as one variable
            //string str1 = "Nour";
            //string str2 = "Ahmed";
            //Console.WriteLine("{0} {1}", str1, str2); // Nour Ahmed

            #endregion

            #region Q8
            //Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            //Note : The formula for simple interest is Interest = (principal * rate * time ) /100.
            //Console.Write("Enter principal amount: ");
            //double.TryParse(Console.ReadLine(), out double principalAmount);
            //Console.Write("Enter rate of interest: ");
            //float.TryParse(Console.ReadLine(), out float rateOfInterest);
            //Console.Write("Enter time : ");
            //double.TryParse(Console.ReadLine(), out double time);
            //double simpleInterest = (principalAmount * rateOfInterest * time) / 100;
            //Console.WriteLine("Simple Interest = " + simpleInterest);
            #endregion

            #region Q9
            //Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            //Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.WriteLine("Enter your weight in kilograms: ");
            //double.TryParse(Console.ReadLine(), out double weight);
            //Console.WriteLine("Enter your height in meters: ");
            //double.TryParse(Console.ReadLine(), out double height);
            //double bmi = weight / (height * height);
            //Console.WriteLine("Your Body Mass Index (BMI) is: " + bmi);


            #endregion

            #region Q10
            //Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
            //Note:
            //a. that below 10 degrees is "Just Cold"
            //b.above 30 degrees is "Just Hot"
            //c.anything else is "Just Good"
            //Console.WriteLine("Enter the temperature : ");
            //int.TryParse(Console.ReadLine(), out int temperature);
            //string message = temperature < 10 ? "Just Cold" :( temperature > 30 ? "gust Hot " : "just Good");
            //Console.WriteLine(message); 
            #endregion

            #region Q11
            //.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001
            //Console.Write("enter the day : ");
            //int.TryParse(Console.ReadLine(), out int day);
            //Console.Write("enter the day : ");
            //int.TryParse(Console.ReadLine(), out int month);
            //Console.Write("enter the day : ");
            //int.TryParse(Console.ReadLine(), out int year);
            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}");

            #endregion

            #region Q12
            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //Input: 12
            //Output: Yes
            //Example(2)
            //Input: 9
            //Output: No
            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //string result = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            //Console.WriteLine(result);

            #endregion

            #region Q13
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Example(1)
            //Input: -5
            //Output: negative
            //Example(2)
            //Input: 10
            //Output: positive
            //Console.Write("enter an integer: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //if (number > 0) {
            //    Console.WriteLine("positive");
            //}
            //else if (number < 0) {
            //    Console.WriteLine("negative");
            //}
            //else {
            //    Console.WriteLine("zero");
            //}


            #endregion

            #region Q14
            //Write a program that takes 3 integers from the user then prints the max element and the min element.
            /*
               Example (1)
               Input:7,8,5
               Output:
               max element = 8
               min element = 5
               —--------------------------------
               Example (2)
               Input: 3 6 9
               Outputs:
               Max element = 9
               Min element = 3

             */
            //Console.Write("Enter first number: ");
            //int.TryParse(Console.ReadLine(), out int number01);
            //Console.Write("Enter second number: ");
            //int.TryParse(Console.ReadLine(), out int number02);
            //Console.Write("Enter third number: ");
            //int.TryParse(Console.ReadLine(), out int number03);
            //int max = 0;
            //int min = 0;
            //if (number01 > number02 && number01 > number03)
            //{
            //    max = number01;
            //}
            //else if (number02 > number01 && number02 > number03)
            //{
            //    max = number02;
            //}
            //else
            //{
            //    max = number03;
            //}
            //if (number01 < number02 && number01 < number03)
            //{
            //    min = number01;
            //}
            //else if (number02 < number01 && number02 < number03)
            //{
            //    min = number02;
            //}
            //else
            //{
            //    min = number03;
            //}

            //Console.WriteLine("max element = " + max);
            //Console.WriteLine("min element = " + min);

            #endregion

            #region Q15
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("enter a number : ");
            //int.TryParse(Console.ReadLine(), out int number);
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion


            #region Q16
            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            /* 
             Example (1)
             Input: O
             Output: vowel
             Example (2)
             Input: b
             Output: Consonant

             */
            //Console.Write("enter a character : ");
            //char x = Console.ReadLine()[0];
            //if (x =='a' || x == 'e' || x == 'i' || x == 'o' || x == 'u' ||
            //    x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}

            #endregion


            #region Q17
            //Write a program to input the month number and print the number of days in that month
            /*
             * Example
               Input: Month Number: 1
               Output: Days in Month: 31

             */

            //Console.Write("Enter month number : ");
            //int.TryParse(Console.ReadLine(), out int monthNumber);
            //int daysInMonth = 0;
            //switch (monthNumber)
            //{
            //    case 1: 
            //    case 3: 
            //    case 5: 
            //    case 7: 
            //    case 8: 
            //    case 10: 
            //    case 12: 
            //        daysInMonth = 31;
            //        break;
            //    case 4: 
            //    case 6: 
            //    case 9: 
            //    case 11:
            //        daysInMonth = 30;
            //        break;
            //    case 2: 
            //        daysInMonth = 28; 
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //}
            #endregion


        }
    }
}