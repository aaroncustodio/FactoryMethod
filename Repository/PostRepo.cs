using System;
using Entity;
using System.Collections.Generic;

namespace Repository
{
    public class PostRepo
    {
        public List<Post> PostList = new List<Post>
        {
            new Post {ID=new Guid(), Content="Hello internet!", DateCreated=DateTime.Now},
            new Post {ID=new Guid(), Content="Hello Hello!", DateCreated=DateTime.Now}
        };

        public void AddPostToRepo(Post newPost)
        {
            PostList.Add(newPost);
        }

        public void DeletePostInRepo(Guid id)
        {
            PostList.RemoveAll(a => a.ID == id);
        }
    }
}
