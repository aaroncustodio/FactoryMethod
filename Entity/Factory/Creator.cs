using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Factory
{
    public abstract class PageFactory
    {
        public abstract Page CreatePage(int choice);
    }
}
