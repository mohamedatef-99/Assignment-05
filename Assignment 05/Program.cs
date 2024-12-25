namespace Assignment_05
{
    internal class Program
    {
        //static void DoSomeCode()
        //{
        //    try { 
        //        int x, y, z;
        //    x = int.Parse(Console.ReadLine());
        //    y = int.Parse(Console.ReadLine());
        //    z = x + y;
        //    int[] arr = { 1, 2, 3, 4, 5 };
        //    arr[99] = 10;
        //    }
        //    //catch
        //    //{
        //    //    Console.WriteLine("Error");
        //    //}
        //    catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Finally");
        //        // Disconnect | Dipose Unmanaged Resources
        //    }
        //}
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

            #region Nullable Referene Type
            //// Nullable Reference Type

            //string message = null; // required

            //string? message2 = null;  // nullable

            //Console.WriteLine(message.Length);
            //Console.WriteLine(message2); 
            #endregion

            #region Null Propagation Operator
            // Null Propagation Operator ?

            //double x = default; // 0
            //bool c = default; // false

            //int[] arr = default; // null

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            ////int len = arr is not null ? arr.Length : 0;
            //int? len = arr?.Length;
            //int len = arr?.Length ?? 0; 
            #endregion

            #region Exception
            //DoSomeCode();
            //Console.WriteLine("helle after exception");

            //// Exception
            //// 1. system exception
            ////1.1. FormatException
            ////1.2. IndexOutOfRangeException
            ////1.3. NullReferenceException
            ////1.4. ArithmeticException
            //       //1.4.1 OverFlowException
            //       //

            //// 2. application exception 
            #endregion
        }
    }
}
