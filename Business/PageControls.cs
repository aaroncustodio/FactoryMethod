using System;
using Repository;
using Entity.Factory;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PageControls
    {
        ConcreteCreator pagecrtor = new ConcreteCreator();
        PageRepo pr = new PageRepo();

        public void NewPage(int i)
        {
            Page pg = pagecrtor.CreatePage(i);

            pr.AddPageToRepo(pg);
        }
    }
}
