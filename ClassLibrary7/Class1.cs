namespace ClassLibrary7
{
    public class Work
    {
        public void MetodoSequenziale()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            int D = A + 5;
            Console.WriteLine("D:" + D);
            int E = B * 2;
            Console.WriteLine("E: "+E);
            int F = C * C;
            Console.WriteLine("F: " + F);
            int G = E - D;
            Console.WriteLine("G: " + G);
            int H = F + G;
            Console.WriteLine("H: " +H);

        }
        public void MetodoParallelo()
        {
            int A, B, C, D, E, F, G, H;
        }
    }
}
