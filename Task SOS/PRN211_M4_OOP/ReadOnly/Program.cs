namespace ReadOnly
{
    class SamplePoint
    {
        public readonly int x = 10;
        public readonly int y;
        public int z;
        public const int t=100;

        public SamplePoint()
        {
            
            z = 10;
            y = 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SamplePoint samplePoint = new SamplePoint();
            
            Console.WriteLine($"x = {samplePoint.x}, y = {samplePoint.y}, z = {samplePoint.z}");
        }
    }
}