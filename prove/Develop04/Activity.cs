


public class Activity
{
    protected string _startMessage;
    protected string _activityDescriptor;
    protected string _endMessage;
    protected int _duration;



    public Activity(string startMessage, string activiyDescriptor, string endMessage)
    {
        _startMessage = startMessage;
        _activityDescriptor = activiyDescriptor;
        _endMessage = endMessage;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine(_startMessage);
    }
    public void DisplayActivityDescriptor()
    {
        Console.WriteLine(_activityDescriptor);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
    }
    public void SetDuration(int integer)
    {
        _duration = integer;
        Console.WriteLine($"You will do the exercise for {_duration} seconds");
    }
    public void Wait()
    {
        Thread.Sleep(1000);
    }
    public void Animation()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        // while (startTime < futureTime)
        // {
        //     int between = 250;
        //     Console.Write("-\b");
        //     Thread.Sleep(between);

        //     Console.Write("\\\b");
        //     Thread.Sleep(between);

        //     Console.Write("|\b");
        //     Thread.Sleep(between);

        //     Console.Write("/\b");
        //     Thread.Sleep(between);

        //     startTime = DateTime.Now;
        // }

         while (startTime < futureTime)
        {
            int between = 140;
            Console.Write("-->\b");
            Thread.Sleep(between);

            Console.Write("-->\b");
            Thread.Sleep(between);

            Console.Write("-->\b");
            Thread.Sleep(between);

            Console.Write("-->\b");
            Thread.Sleep(between);

            startTime = DateTime.Now;
        }
    }
}