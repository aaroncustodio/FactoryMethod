using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Factory
{
    public class LocalBusinessPage : Page
    {
        public override void SamplePageMethod()
        {
            Console.WriteLine("Local Business Page!");
        }
    }

    class ArtistPage : Page
    {
        public override void SamplePageMethod()
        {
            Console.WriteLine("Artist Page!");
        }
    }

    class EntertainmentPage : Page
    {
        public override void SamplePageMethod()
        {
            Console.WriteLine("Entertainment Page!");
        }
    }
}
