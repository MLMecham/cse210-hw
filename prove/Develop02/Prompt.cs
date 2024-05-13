class Prompt
{
static public List<string> promptList = new() {"What was your favorite part of today?", "What are three things that you are happy for?", "What are three things that you learned today?", "What did you do to help another today?", "Did you acheive your daily goals. Why or why not?"};




public static string ChoosePrompt()
{
    Random rand = new Random();
    int index = rand.Next(promptList.Count);
    return promptList[index];
}

}