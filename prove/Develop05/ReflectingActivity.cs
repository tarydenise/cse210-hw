public class ReflectingActivity : Activity
{
   private List<string> _prompts = new List<string>
   {
    // List of prompts
   };

   private List<string> _questions = new List<string>
   {
    // List of questions
   };

   public ReflectingActivity(string name, string description, string duration, string prompts, string questions) : base(name, description, duration)
   {
    // Insert here
   }

   public void Run()
   {
    // insert here
   }

   public string GetRandomPrompt()
   {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
   }

   public string GetRandomQuestions()
   {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
   }

   public void DisplayPrompt()
   {
    // insert here
   }

   public void DisplayQuestions()
   {
    //insert here
   } 
}