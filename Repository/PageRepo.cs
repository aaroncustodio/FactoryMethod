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
        
        };

        public void AddPageToRepo(Page newPage)
        {
            PageList.Add(newPage);
        }

    }
}
