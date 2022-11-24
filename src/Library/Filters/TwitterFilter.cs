using System.Drawing;
using System;
using TwitterUCU;
namespace CompAndDel.Filters
{
    public class TwitterFilter : IFilter
    {
       
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("Hola, soy un tweet",@$" Luke.jpg"));
            return image;
        }
    }
}
