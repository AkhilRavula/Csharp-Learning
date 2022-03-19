
namespace MulticastDelegate_2
{
    class MulticastDelLearn
    {
        public delegate void rect(double width, double height); //single delegate calling both methods
        public static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.GetArea(12.33, 13.33);
            rectangle.GetPerimeter(12, 14);
            rect rect1 = new rect(rectangle.GetArea);
            // rect rect2 = rectangle.GetPerimeter;//we can directly bind method to delegate other than sending to constructur
            rect1 += rectangle.GetPerimeter;

            rect1.Invoke(12, 14);//this will invoke both methods
            //if the both methods are having return type only method 2 value is stored or returned as it overwrites the 1st one return.
            //make sure when we use multicast delegates we sud have or use void methods
        }
    }

}