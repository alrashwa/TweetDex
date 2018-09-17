namespace TweetDex.Core.Repositories
{
    public interface ITweetRepository
    {
        string GetMostRecentTweet();
        
    }
    public class TweetRepository : ITweetRepository
    {
        //here is where we can sub in the Tweet query (register the source in startup.cs and inject here, like we did before. Use Addtransient in the startup.cs) 
        public string GetMostRecentTweet() => "MAGA!";
    }
}
