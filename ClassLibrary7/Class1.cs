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
            int A = 0, B = 0, C = 0, D = 0, E = 0, F = 0, G = 0, H = 0;

            Thread assegnaA = new Thread(() =>
            {
                A = 10;
            });
            assegnaA.Start();
            Thread assegnaB = new Thread(() =>
            {
                B = 20;
            });
            assegnaB.Start();
            Thread assegnaC = new Thread(() =>
            {
                C = 30;
            });
            assegnaC.Start();

            assegnaA.Join();
            assegnaB.Join();
            assegnaC.Join();

            Thread calcolaD = new Thread(() =>
            {
                D = A + 5;
            });
            calcolaD.Start();
            Thread CalcolaE = new Thread(() =>
            {
                E = B * 2;
            });
            CalcolaE.Start();
            Thread CalcolaF = new Thread(() =>
            {
                F = C * C;
            });
            CalcolaF.Start();

            calcolaD.Join();
            CalcolaE.Join();
            CalcolaF.Join();

            Thread ScriviD = new Thread(() =>
            {
                Console.WriteLine("D: " + D);
            });
            ScriviD.Start();
            Thread ScriviE = new Thread(() =>
            {
                Console.WriteLine("E: " + E);
            });
            ScriviE.Start();
            Thread ScriviF = new Thread(() =>
            {
                Console.WriteLine("F: " + F);
            });
            ScriviF.Start();

            ScriviD.Join();
            ScriviE.Join();
            ScriviF.Join();

            Thread CalcolaG = new Thread(() =>
            {
                G = E - D;
            });
            CalcolaG.Start();

            Thread CalcolaH = new Thread(() =>
            {
                H = F + G;
            });
            CalcolaH.Start();

            CalcolaG.Join();
            CalcolaH.Join();

            Thread ScriviG = new Thread(() =>
            {
                Console.WriteLine("G: " + G);
            });
            ScriviG.Start();

            Thread ScriviH = new Thread(() =>
            {
                Console.WriteLine("H: " + H);
            });
            ScriviH.Start();
            ScriviG.Join();
            ScriviH.Join();
        }
    }
}
