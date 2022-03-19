
//generic makes methods independent.
//boxing and unboxing we can avoid.
//every type is inherited from system.object class .so we can use areequal(object val1,object val2) ,but since we are sending a value type
//to reference type variable it needs unboxing hence degrades progrm performance.
namespace Generics
{
    public class MainClas
    {
        public static void Main()
        {
            //bool answer=CalculateVal.AreEqual<string>("srt", "srt"); //calling method as generic type with string so only we can pass strings
            bool answer = CalculateVal<string>.AreEqual("srt", "srt"); //using generic type to class.
            if (answer)
            {
                Console.WriteLine("qwer");
            }
            else
            {
                Console.WriteLine("sss");
            }
        }
    }


    public class CalculateVal<T> //using generic type to class
    {
       // public static bool AreEqual<T>(T val1,T val2)
            //generic type by giving <t> before it so it only takes generic type given in calling method.
        public static bool AreEqual(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
}

