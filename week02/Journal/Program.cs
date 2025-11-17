using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator questions = new PromptGenerator();
        questions._prompts = new List<string>
        {
            "What have you done today?",
            "Who do you met today?",
            "What is was your favorite moment of the day?"
        };

        Journal journal = new Journal();

         bool running = true;

        while (running)
        {
            Console.WriteLine("1 - Write");
            Console.WriteLine("2 - Display");
            Console.WriteLine("3 - Save");
            Console.WriteLine("4 - Load");
            Console.WriteLine("5 - Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = questions.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToString("dd/MM/yyyy"),
                        _promptText = prompt,
                        _entryText = response
                    };

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Journal Entries ---");
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}