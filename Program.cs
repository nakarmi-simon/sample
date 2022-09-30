namespace EULER{
    class Program{
        static void Main(string[] args)
        {
            Solutions solutions=new Solutions();

            Console.WriteLine("P1");
            Console.WriteLine(solutions.Multiples(new int[]{3,5},1000));

            Console.WriteLine("P2");
            Console.WriteLine(solutions.FibSum());

            // Console.WriteLine("P3");
            // Console.WriteLine(solutions.LargestPrimeFactor());

            Console.WriteLine(solutions.P4());

            Console.WriteLine(solutions.P5());

            Console.WriteLine(solutions.P6());

            Console.WriteLine(solutions.P7());

            Console.WriteLine(solutions.P8());

            Console.WriteLine(solutions.P9());

            //Console.WriteLine(solutions.P10());

            Console.WriteLine(solutions.P11());
        }
    }
}
