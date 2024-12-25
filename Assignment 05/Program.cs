namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            //// Boxing and Unboxing

            //// Boxing: casting from valueType to referenceType
            //// Unboxing: casting from referenceType to valueType

            //object o1;

            //// o1 ==> can refere to instance of Object or an instance of any type

            //o1 = 10; // cast from int to object
            //o1 = "Hello"; // cast from string to object

            //int x = 5;
            //object o1 = x;

            //// implicit casing
            //// safe casting
            //// boxing
            //// parent = child => child is parent

            //object o1 = 3;
            //o1 = "Hello";

            //// unboxing
            //// explicit casting
            //// unsafe casting 
            #endregion

            #region Nullable Value Type
            // Nullable Types

            // Value type
            // Reference type


            //int x = 5;
            //x = null; // error not valid

            //int? age = 20; // Nullable type allow null
            //age = null; 

            //double? salary = 5000.0;

            //salary = null;

            //int? x = 5;

            //int? y = x;
            //// implicit casting
            //// safe casting

            //int? x =5;
            //int y =(int) x;
            //// explicit casting
            //// unsafe casting

            //if (x != null)
            //    y = (int)x;
            //else
            //    y = 0; 
            #endregion







        }
    }
}
