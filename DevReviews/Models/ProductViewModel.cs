using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReviews.Models
{
    public class ProductViewModel
    {
        public ProductViewModel(int id, string title, decimal price)
        {
            this.id = id;
            Title = title;
            this.price = price;
        }

        public int id { get; private set; }
        public string Title { get; private set; }
        public decimal price { get; private set; }
    }
}