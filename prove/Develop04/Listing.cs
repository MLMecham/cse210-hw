class Listing : Activity
{
    List<string> _promptList;
    List<string> _responseList;
    // int _responseCount;

    public Listing(string startMessage, string activiyDescriptor, string endMessage, List<string> promptList) : base(startMessage, activiyDescriptor, endMessage)
    {
        _promptList = promptList;
        _responseList = new List<string>();
    }

    public void DisplayRandomPrompt()
    {
        Random rand = new();
        int randint = rand.Next(0, _promptList.Count());
        Console.WriteLine(_promptList[randint]);
    }

    public void ListingActivity()
    {
        
        Console.WriteLine("take a few seconds to think about the prompt, then record your answers until the time runs out.");
        Animation();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Console.WriteLine("\nBegin listing\n");
        string response;
        while (startTime < futureTime)
        {
            response = Console.ReadLine();
            _responseList.Add(response);
            Console.WriteLine("");

            startTime = DateTime.Now;
        }
    }

    public void DisplayResponseCount()
    {
        Console.WriteLine($"You listed {_responseList.Count()} things.");
    }
}