using System.Reflection;

class Stretch : Activity
{

    List<string> _stretchAnimation;
    public Stretch(string startMessage, string activiyDescriptor, string endMessage, List<string> stretchAnimation) : base(startMessage, activiyDescriptor, endMessage)
    {
        _stretchAnimation = stretchAnimation;
    }

    public void StretchActivity()
    {
        
    }

    public void DisplayStretch()
    {
        foreach (string stretch in _stretchAnimation)
        {
            Console.Clear();
            Console.WriteLine(stretch);

            Thread.Sleep(1500);
        }

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        // while (startTime < futureTime)
        // {
        //     Console.Write($"{_duration} ");
        //     _duration = _duration - 1;
            
        //     Thread.Sleep(1000);
        //     Console.Write("\b\b\b\b");
        //     startTime = DateTime.Now;
        // }

        while (startTime < futureTime)
        {
            string durationString = $"{_duration} ";
            Console.Write(durationString);
            _duration = _duration - 1;
            
            Thread.Sleep(1000);
            
            // This lets the code move back the same number of spaces as the duration string
            for (int i = 0; i < durationString.Length; i++)
            {
                Console.Write("\b");
            }

            startTime = DateTime.Now;
        }
        Console.WriteLine("");
        Console.Write("\a");

        
    }
}