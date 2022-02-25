using System;
using System.Collections.Generic;

namespace using_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // At this point, if you want to invoke the above AreEqual() method, then you need to specify the data type
            // on which the method should operate. For example, if you want to work with integer values, then you need 
            // to invoke the AreEqual() method by specifying double as the data type as shown in the below code using angular
            // brackets
            bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 10.5);
            if(IsEqual)
            {
                Console.WriteLine("Both are Equal!");
            }
            else
            {
                Console.WriteLine("Both are not Equal!");
            }
        }

        public class ClsCalculator
        {
            // Here in the above example, in order to make the AreEqual() method generic
            // (generic means the same method will work with the different data type), we specified the type
            // parameter T using the angular brackets <T>. Then we use that type as the data type for the method parameters
            // as shown in the below image. 
            public static bool AreEqual<T>(T value1, T value2)
            {
                return value1.Equals(value2);
            }
        }
    }
}
