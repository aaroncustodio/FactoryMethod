using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Factory
{
    public class Page : BaseClass
    {
        public string PageName { get; set; }
        public int Likes { get; set; }
        public int Follows { get; set; }
        public List<Post> PagePosts { get; set; }
        public abstract void SamplePageMethod();

    }
    
}
