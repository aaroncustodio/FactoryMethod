using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    class PostControls
    {
        
        PostRepo pstRep = new PostRepo();
        public void ViewPost()
        {

        }

        public void CreatePost(Guid id, User postedby, string content)
        {
            Post NewPost = new Post
            {
                ID = new Guid(),
                PostedBy = postedby,
                Content = content,
                DateCreated = DateTime.Now
            };

            pstRep.AddPostToRepo(NewPost);
        }

        public void DeletePost()
        {

        }
    }
}
