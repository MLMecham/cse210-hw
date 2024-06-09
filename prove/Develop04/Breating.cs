class Breathing : Activity
{
    public Breathing(string startMessage, string activiyDescriptor, string endMessage) : base(startMessage, activiyDescriptor, endMessage)
    {

    }

    public void BreatingActivity()
    {


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (startTime < futureTime)
        {
            Console.WriteLine("");
            Console.WriteLine("Breath in for 6...");
            Console.WriteLine("1");

            Thread.Sleep(1000);
            Console.WriteLine("2");

            Thread.Sleep(1000);
            Console.WriteLine("3");

            Thread.Sleep(1000);
            Console.WriteLine("4");

            Thread.Sleep(1000);
            Console.WriteLine("5");

            Thread.Sleep(1000);
            Console.WriteLine("6");
            Thread.Sleep(1000);
            
            Console.WriteLine("");
            Console.WriteLine("Breath out for 6...");
            Console.WriteLine("1");

            Thread.Sleep(1000);
            Console.WriteLine("2");

            Thread.Sleep(1000);
            Console.WriteLine("3");

            Thread.Sleep(1000);
            Console.WriteLine("4");

            Thread.Sleep(1000);
            Console.WriteLine("5");

            Thread.Sleep(1000);
            Console.WriteLine("6");
            Thread.Sleep(1000);

            startTime = DateTime.Now;
        }
    }
}