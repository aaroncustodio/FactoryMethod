using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Factory
{
    public class ConcreteCreator : PageFactory
    {
        public override Page CreatePage(int creator)
        {
            switch (creator)
            {
                case 1:
                    return new LocalBusinessPage();
                case 2:
                    return new ArtistPage();
                case 3:
                    return new EntertainmentPage();
                default:
                    return null;
            }
            
        }
    }
}
