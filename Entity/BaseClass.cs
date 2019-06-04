using System;

namespace Entity
{
    public class BaseClass
    {
        private Guid id;
        private DateTime dateCreated;
        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
    }
}
