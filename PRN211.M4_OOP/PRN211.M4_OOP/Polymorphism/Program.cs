namespace Polymorphism
{
    abstract class Shape
        {
            public abstract void Draw();        
            
        }
    class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }

    class Circle3D:Circle
    {
        //override or new
        public new void Draw()
        {
            Console.WriteLine("Draw Circle 3D");    
        }
    }

    class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle();
            shapes[2] = new Rectangle();
            shapes[3] = new Circle3D();
            foreach (Shape shape in shapes)
                shape.Draw();

            ((Circle3D)shapes[3]).Draw();

        }
    }
}