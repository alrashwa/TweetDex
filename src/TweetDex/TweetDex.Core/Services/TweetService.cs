namespace TweetDex.Core.Services
{
    using Core.Repositories;

    public interface ITweetService
    {
        string GetMostRecentTweet();

    }
    public class TweetService : ITweetService
    {
        private readonly ITweetRepository tweetRepository;

        public TweetService(ITweetRepository tweetRepository)
        {
            this.tweetRepository = tweetRepository;
        }
        
        public string GetMostRecentTweet() => tweetRepository.GetMostRecentTweet();
    }
}
