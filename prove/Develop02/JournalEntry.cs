using System.Formats.Tar;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _entry;
    

public static JournalEntry WriteEntry()
{

    JournalEntry entry = new JournalEntry();
    entry._date = DateTime.Now.ToString();

    Prompt prompt = new Prompt();
    entry._prompt = Prompt.ChoosePrompt();
    Console.WriteLine(entry._prompt);
    Console.Write("Please write your entry:" + Environment.NewLine);
    entry._entry = Console.ReadLine();
    return entry;
}


}