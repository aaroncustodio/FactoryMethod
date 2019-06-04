using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Factory
{
        public abstract class PageType : BaseClass
        {
            public abstract string PageName { get; set; }
            public abstract int Likes { get; set; }
            public abstract int Follows { get; set; }
            public abstract List<Post> PagePosts { get; set; }
            public abstract void SamplePageMethod();

        }
    }
}
