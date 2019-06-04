using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Factory
{
    class LocalBusinessPage : PageType
    {
        #region encaps
        //private string pageName;
        //private int likes;
        //private int follows;
        //private List<Post> pagePosts;
        //public override string PageName
        //{
        //    get { return pageName; }
        //    set { pageName = value; }
        //}
        //public override int Likes
        //{
        //    get { return likes; }
        //    set { likes = value; }
        //}
        //public override int Follows
        //{
        //    get { return follows; }
        //    set { follows = value; }
        //}
        //public override List<Post> PagePosts
        //{
        //    get { return pagePosts; }
        //    set { pagePosts = value; }
        //} 
        #endregion
        public override string PageName { get; set; }
        public override int Likes { get; set; }
        public override int Follows { get; set; }
        public override List<Post> PagePosts { get; set; }

        public override void SamplePageMethod()
        {
            throw new NotImplementedException();
        }
    }

    class ArtistPage : PageType
    {
        public override string PageName { get; set; }
        public override int Likes { get; set; }
        public override int Follows { get; set; }
        public override List<Post> PagePosts { get; set; }

        public override void SamplePageMethod()
        {
            throw new NotImplementedException();
        }
    }

    class EntertainmentPage : PageType
    {
        public override string PageName { get; set; }
        public override int Likes { get; set; }
        public override int Follows { get; set; }
        public override List<Post> PagePosts { get; set; }

        public override void SamplePageMethod()
        {
            throw new NotImplementedException();
        }
    }
}
