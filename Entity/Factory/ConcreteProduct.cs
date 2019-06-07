using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Factory
{
    public class LocalBusinessPage : Page
    {
        public LocalBusinessPage()
        {
            PageType = "Local Business";
        }
        public override void SamplePageMethod()
        {
            Console.WriteLine("Local Business Page!");
        }
    }

    class ArtistPage : Page
    {
        public ArtistPage()
        {
            PageType = "Artist/Band";
        }
        public override void SamplePageMethod()
        {
            Console.WriteLine("Artist Page!");
        }
    }

    class EntertainmentPage : Page
    {
        public EntertainmentPage()
        {
            PageType = "Entertainment";
        }
        public override void SamplePageMethod()
        {
            Console.WriteLine("Entertainment Page!");
        }
    }
}
