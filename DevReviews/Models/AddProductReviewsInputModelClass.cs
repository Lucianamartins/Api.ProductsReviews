using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReviews.Models
{
    public class AddProductReviewsInputModelClass
    {
        public int Rating { get; set; }
        public string Author { get; set;  }
        public string Comments { get; set;  }
    }
}
