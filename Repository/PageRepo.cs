using System;
using Entity.Factory;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class PageRepo
    {
        public List<Page> PageList = new List<Page>
        {
            //new Page {PageName="Linkin Park", Likes=100000, ID=new Guid(), PageType="Artist/Band"},
            //new Page {PageName="Cofftea", Likes=100000, ID=new Guid(), PageType="Local Business"}
        };

        public void AddPageToRepo(Page newPage)
        {
            PageList.Add(newPage);
        }

        public void ViewPages()
        {
            foreach (Page pg in PageList)
            {
                Console.WriteLine("Page type: {1}", pg.PageName, pg.PageType);
            }
        }

    }
}
