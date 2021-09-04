using AutoMapper;
using DevReviews.Controllers.Entities;
using DevReviews.Models;

namespace DevReviews.API.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductReview, ProductReviewModel>();
            CreateMap<Products, ProductViewModel>();
            CreateMap<Products, ProductDetaislViewModel>();
        }
    }
}