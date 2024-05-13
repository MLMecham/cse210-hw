class Journal
{
    static public List<JournalEntry> currentJournal = new List<JournalEntry>();

public static void DisplayJournal()
{
    foreach (JournalEntry entry in currentJournal)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Entry: {entry._entry}");
            // Console.WriteLine(entry._date);
            // Console.WriteLine(entry._prompt);
            // Console.WriteLine(entry._entry);
        }
}
public static void AddEntryToJournal(JournalEntry entry)
{
    
    currentJournal.Add(entry);
}

}