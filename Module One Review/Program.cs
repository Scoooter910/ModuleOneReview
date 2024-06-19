namespace Module_One_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            
            Console.WriteLine("Enter the radius of the circle: ");

            // Getting user input and convert it to double (assuming radius is a double)
            double radius = Convert.ToDouble(Console.ReadLine());

            // Calling the AreaOfCircle function with the user-provided radius
            AreaOfCircle(radius);

            Console.WriteLine("Enter the base length of the triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            // Prompting user for height
            Console.WriteLine("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calling AreaOfTriangle function with user-provided values
            AreaOfTriangle(baseLength, height);

            // Prompting user for width
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompting user for length
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calling AreaOfRectangle function with user-provided values
            AreaOfRectangle(width, length);

            // Prompting user for side length
            Console.WriteLine("Enter the side length of the square: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            // Calling AreaOfSquare function with user-provided value
            AreaOfSquare(sideLength);

           
        }

        static void AreaOfCircle(double radius)
        {

            const double PI = Math.PI; 

            double area = PI * radius * radius;
            Console.WriteLine($"The area of the circle is: {area}");
        }
        static void AreaOfTriangle(double baselength, double height)
        {
            double area = 0.5 * baselength * height;
            Console.WriteLine($"The area of the triangle is: {area}");
        }
        static void AreaOfRectangle(double width, double length)
        {
            double area = width * length;
            Console.WriteLine($"The area of the rectangle is: {area}");
        }   
        static void AreaOfSquare(double side)
        { 
            double area = side * side;
            Console.WriteLine($"This area of the square is: {area}");
        }
    }
}
