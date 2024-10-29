using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_7
{
	internal class String_1
	{
		static void Main(string[] args)
		{
            //	// Define .NET Strings  	            // String of characters  
            //	string authorName = "Mahesh Chand";

            //	// String made of an Integer  
            //	string age = "33";

            //	// String made of a double  
            //	string numberString = "33.23";

            //	// Write to Console.  
            //	Console.WriteLine("Name: {0}", authorName);
            //	Console.WriteLine("Age: {0}", age);
            //	Console.WriteLine("Number: {0}", numberString);
            //	//Console.ReadKey();

            //  string nowDateTime = "Date: " + DateTime.Now.ToString("D");
            //  string firstName = "Mahesh";
            // string lastName = "Chand";
            // string age = "33";
            //  string authorDetails = firstName + " " + lastName + " is " + age + " years old.";

            //Console.WriteLine(nowDateTime);
            //Console.WriteLine(authorDetails);


            //  string authorInfo = "Mahesh Chand is 33 years old.";
            //  int startPosition = authorInfo.IndexOf("is ") + 1;
            //  string age1 = authorInfo.Substring(startPosition + 2, 2);
            //  Console.WriteLine("Age: " + age1);

            //  string name = "Mahesh Chand";
            //  int age = 33;
            //  string authorInfo = string.Format("{0} is {1} years old.", name, age.ToString());
            //Console.WriteLine(authorInfo);

              string nameString = "Mahesh Chand";
              for (int counter = 0; counter <= nameString.Length - 1; counter++)
                Console.WriteLine(nameString[counter]);


        }

    }
}

