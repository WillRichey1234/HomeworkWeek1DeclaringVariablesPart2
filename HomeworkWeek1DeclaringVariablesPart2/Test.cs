using NUnit.Framework;
using System;
namespace HomeworkWeek1DeclaringVariablesPart2
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            /*The capitalization allows me to
             * make another variable with
             * the exact same words but different
             * capitalization and have them both mean two 
             * different things. Try not to do this thouhg
             */
         /* The var creates a variable and does the
          * same thing as a int or a string. It must be set
          * equal to something
          */
           // string myFirstName = "Garrett";
            //Console.WriteLine(myFirstName);
            //Console.ReadLine();
            /* This will write on the screen whatever
		  * I plug in for the variable myFirstName
		  */

            int x = 7;
            string y = "Garrett";
            string myFirstTry = x.ToString()  + y;
            Console.WriteLine(myFirstTry);
            Console.ReadLine();

		}
    }
}
