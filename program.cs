using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerFundamentals // Note: actual namespace depends on the project name.
{

    internal static class Program //By default we have a class called program.
    {
        static void Main(string[] args) //We have a method or a function called Main and that's the entry point to the application.
                                        //When you run your app, CLR executes the code inside main method and this is where everything kicks off this method is delcated as static.
                                        //Methods have input and output. So what goes inside parentheses the input to the method which we call parameter or arugment. e.g. (string[] args)
                                        //e.g. (string[] args) - the main method has a parameter called args which is of type String Array
                                        //void - means that this method does not return any value. It just contains some code.
                                        //C# is case senesitive. Main has to be with a capital M because CLRR is not going to find this method as the entry point of the app. 
                                        //{} - we need to surround it with curly braces so that it is applicable for methods for classes and for name spaces. 

        {

            Console.WriteLine("Hello World!");

            //If/Else Statements
            int hour = 12;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Its Afternoon.");
            }

            //e.g

            bool isGoldCustomer = true;

            //float price;

            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            //Switch/Case Statements

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

            //e.g If/Else Statements
            int number = 5;
            if (number > 0 && number < 10)
            {
                Console.WriteLine("Valid");
            }
            else if (number < 0 && number > 10)
            {
                Console.WriteLine("Invalid");
            }


            //e.g If/Else Statements
            int getMinNum = 4;
            int getMaxNum = 10;

            if (getMinNum < getMaxNum)
            {
                Console.WriteLine(getMinNum);
            }
            else if (getMaxNum > getMinNum)
            {
                Console.WriteLine(getMaxNum);
            }

            //Switch/Case Statements 
            var Car = CarBrand.Kia;
            switch (Car)
            {
                case CarBrand.Honda:
                case CarBrand.Toyota:
                    Console.WriteLine("We didn't get our dream car.");
                    break;

                case CarBrand.Kia:
                case CarBrand.Tesla:
                    Console.WriteLine("We get our dream car.");
                    break;

            }

            //For Loops

            //for (var i = 0; i <10; i++) //i++ - Iteration Clause
            // i < 10 - Condition Clause
            // var i = 0 - Initialization Clause - control the numbe rof times the loop will iterate
            {
                //sequence of statements that will execute repeatedly
            }

            //Foreach Loops
            //foreach (var number in number) //foreach is used to iterate over elements of an numerical object e.g string is a numerical and arrray type is also numerical.
            //This means anything that has some kind of list or array.
            //var number - for each block we have a temporary variable in this case or call it number
            //in number - here is the list or object that we are iterating.
            //So assuming that numbers is an array of integers in every iteration number will hold the value in the current element of the array.
            {

            }

            //While Loops
            //while (i < 10) //(i < 10) - as long as this condition is valid the loop will execute
            {
                //i++;
            }


            //Do-While Loops - loop is executed at least once because the condition is evaluated at the end of the loop.
            //do
            //{
            //    i++;
            //} while (i < 10);



            //For Loop example:

            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            for (var j = 0; j >= 10; j--)
            {
                if (j % 2 == 0)
                    Console.WriteLine(j);
            }


            //What is DateTime? 

            var dateTime = new DateTime(2022, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("Hour:" + now.Hour);
            //Console.WriteLine("Minute:" + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1); //when you want to go back in time

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH"));


            //What is TimeSpan? 
            //We also have a type called time span which represents a length of time. There are a few different ways to create a time span.

            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration" + duration);

            //Properties
            //So each time span has a number of properties that come in pairs. What do you mean by that.
            //Look at this time span it has properties like days hours milliseconds minutes seconds and so on.

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes:" + timeSpan.TotalMinutes);

            //Add and Subtract both return a new timespan
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Now one last thing you need to know about time span is conversion to and from strings. Then we would use ToString method:
            Console.WriteLine("ToString" + timeSpan.ToString());

            // Parse method
            Console.WriteLine("Parse " + TimeSpan.Parse("01:02:03"));


            /*
            //What is Array?
            //Represents a fixed number of variables of a particular type.
            //What is Single Dimension Arrays?
            //var numbers = new int[5];
            //var numbers = new int[5] { 1, 2, 3, 4, 5 };

            //Syntax (2d dimentional array)
            var matrix = new int[3, 5];
            var getMatrix = new int[3, 5]
            {
                { 1, 2, 3, 4, 5},
                { 6, 7, 8, 9, 10},
                { 11, 12, 13, 14, 15 }
            };

            var element = matrix[0, 0];


            //Syntax (Rectangular 3D
                        var colors = new int[3, 5, 4];
            - So in this example our colors array has three dimensions.
            - But we need to supply the index of the row and the column if we want to declare a three dimensional array.



            What is Multi Dimension Arrays?
            - They're two types of multi dimentional arrays which are Rectnagular and Jagged arrays

            Jagged Arrays
            var array = new int [3][];

            Rectangular Arrays
            var array = new int[3, 5];
            

            //Example

            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length " + numbers.Length);

            //IndexOf()
            //This method have five overload methods.
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear() this is the Clear method
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
            Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            Console.WriteLine(n);

            // Sort()
            Array.Sort(another);
            Console.WriteLine("effect of Sort()");
            foreach (var n in numbers)
            Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
            Console.WriteLine(n);

            //What is List?
            //Its a data strcuture storing object of same types. 
            //var numbers = new List<int>();
            //You can create a list of anything such as string, characters, numbers, etc.
            //Useful Methods in the List Methods:
            //Add()
            //AddRAnge()
            //Remove()
            //RemovaAt()
            //IndexOf()
            //Contains()
            */

            var numbers = new List<int>() { 1, 2, 3, 4, }; //you can create a list and initliaze ahead of time
            numbers.Add(1); //You can call the add method to add one object to a list 
            numbers.AddRange(new int[3] { 5, 6, 7 }); //you can call add range to add another list

            foreach (var n in numbers)
                Console.WriteLine(number);

            //IndexOf
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));


            Console.WriteLine("Count: " + numbers.Count);

            //Remove()
            numbers.Remove(1);
            foreach (var n in numbers)
                Console.WriteLine(n);

            //foreach

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var n in numbers)
                Console.WriteLine();
            Console.WriteLine(number);

            //Clear()
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

            //New Topic: File, FileInfo

            //So why do we need different classes for static or instance methods.
            //The difference is if you're going to have a small number of operations that say good attributes about
            //the file it's more convenient to access the static methods of the file class.

            //FileInfo: provides instance methods
            //File: provides static methods 

            /* 
            Create()
            Copy()
            Delete()
            Exists()
            GetAttirbutes()
            Move()
            ReadAllText()
            So here is a list of methods that are pretty useful to know about these classes.

            Again this is not a complete list by any means. 
            My intention is to just give you an idea of what you can do with these classes. 
            So create Mithu is of course used to create a file.
            You also have copy delete exists to check if a file exists.
            Get the attributes which returns the attributes of the given file or move to move the file around or
            read all text which reads all the text in a file directory and directory info are very similar to file
            and file info so directory class provide static methods whereas directory info provides instance methods.

            //What is Directory and DirectoryInfo?
            //Simliar to File and FileInfo

            Directory: provides static methods
            DirectoryInfo: provides instance methods

            
            CreateDirectory()
            Delete()
            Exists()
            GetCurrentDirectory()
            getFiles()
            Move()
            GetLogicalDrives()

            Path
            We also have the path class which provides methods to work with a string that contains a file or directory path information.

            GetDirectoryName()
            GetFilename()
            GetExtension()
            GetTempPath()


            */

            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(content);














        }
    }
}






// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");