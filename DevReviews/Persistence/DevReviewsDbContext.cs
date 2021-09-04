using DevReviews.Controllers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReviews.Persistence
{
    public class DevReviewsDbContext
    {
    
        public DevReviewsDbContext()
        {
            Products = new List<Products>();
        }
        public List<Products> Products { get; set; }
    }
}

