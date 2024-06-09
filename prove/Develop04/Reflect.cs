class Reflect : Activity
{
    List<string> _promptList;
    List<string> _questionList;

    public Reflect(string startMessage, string activiyDescriptor, string endMessage, List<string> promptList, List<string> questionList) : base(startMessage, activiyDescriptor, endMessage)
    {
        _promptList = promptList;
        _questionList = questionList;
    }

    public void DisplayRandomPrompt()
    {
        Random rand = new();
        int randint = rand.Next(0, _promptList.Count());
        Console.WriteLine(_promptList[randint]);
    }

    public void RefletingActivity()
    {
        
        Console.WriteLine("After reading the prompt, other questions will appear one after the other. Please reflect until the time runs out.");
        Animation();
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Random rand = new();
        int randint;
        while (startTime < futureTime)
        {
            randint = rand.Next(0, _questionList.Count());
            Console.WriteLine(_questionList[randint]);
            Animation();
            Console.WriteLine("");

            startTime = DateTime.Now;
        }
    }



}
