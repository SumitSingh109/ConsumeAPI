using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeAPI
{
    public class Catalogue
    {
        public int Book_ID { get; set; }

        public string Book_Name { get; set; }

        public string Book_Author { get; set; }

        public DateTime Book_Registration { get; set; }

        public string Book_Category { get; set; }

        public string Book_Description { get; set; }

        enum Category
        {
            Thriller = 1,
            History = 2,
            Drama = 3,
            Biography = 4

        }
    }
}
