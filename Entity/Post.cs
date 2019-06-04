using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Post : BaseClass
    {
        private User postedBy;
        private string content;

        public User PostedBy
        {
            get { return postedBy; }
            set { postedBy = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
