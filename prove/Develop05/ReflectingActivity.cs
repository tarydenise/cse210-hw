public class ReflectingActivity
{
   private List<string> _prompts = new List<string>
   {
    // List of prompts
   };

   private List<string> _questions = new List<string>
   {
    // List of questions
   };

   public ReflectingActivity(string prompts, string questions)
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