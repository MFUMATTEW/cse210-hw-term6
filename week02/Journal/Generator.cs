public class PromptGenerator
{
    public List<string> _prompts;
    public Random _rand = new Random();

    public string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }
}