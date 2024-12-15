public class ListingActivity : Activity
{
    private int _count;
   private List<string> _prompts = new List<string>
   {
    // List of prompts
   };

    public ListingActivity(string name, string description, string duration, int count, string prompts) : base(name, description, duration)
    {
        // build constructor here
    }

    public void Run()
    {
        // insert here
    }

    public void GetRandomPrompt()
    {
        // insert here
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}