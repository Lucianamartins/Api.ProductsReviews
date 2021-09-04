using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReviews.Models
{
    public class ProductDetaislViewModel
    {
        public ProductDetaislViewModel(int id, string title, string description, decimal price, DateTime dataTime, List<ProductReviewModel> reviews)
        {
           id = id;
            Title = title;
            Description = description;
            Price = price;
            DataTime = dataTime;
            Reviews = reviews;
        }

        public int id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public DateTime DataTime { get; private set; }

        public List<ProductReviewModel> Reviews { get; private set; }

    }

    public class ProductReviewModel
    {
        public ProductReviewModel(int id, string author, int raiting, string comments, DateTime registereAt)
        {
            Id = id;
            Author = author;
            Raiting = raiting;
            Comments = comments;
            RegistereAt = registereAt;
        }

        public int Id { get; set; }
        public string Author { get; set; }
        public int Raiting { get; set; }
        public string Comments { get; set; }
        public DateTime RegistereAt { get; set; }
    }
}
