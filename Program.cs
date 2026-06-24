namespace finaltest_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread[] tids = new Thread[3];

            print p1 = new print();

            for (int i = 0; i < 3; i++)
            {
                tids[i] = new Thread(new ThreadStart(p1.printNum));
                tids[i].Name = "執行儲" + i + ":";
            }
            foreach (Thread t in tids)
            {
                t.Start();
            }
            Thread.Sleep(500);
            Console.WriteLine(print.str);
        }
    }
}

