using AutoMapper;
using DevReviews.Controllers.Entities;
using DevReviews.Controllers.Models;
using DevReviews.Models;
using DevReviews.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DevReviews.Controllers

{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly DevReviewsDbContext _dbContext;
        private readonly IMapper _mapper;
        public ProductsController(DevReviewsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _dbContext.Products;
            //select para gerar a lista

            var productViewModel = _mapper.Map<List<ProductViewModel>>(products);

            return Ok(productViewModel);
        }
        [HttpGet("{id}")]
        public IActionResult GetByid(int id)
        {
            var product = _dbContext.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
            {

                return NotFound();
            }

            var reviewsViewModel = product
            .Reviews
            .Select(r => new ProductReviewModel(r.Id, r.Author, r.Rating, r.Comments, r.RegisteredAt)).ToList();

            var ProductDetails = new ProductDetaislViewModel(
                product.Id,
                product.Title,
                product.Description,
                product.Price,
                product.RegisteredAt,
                reviewsViewModel
                );

            return Ok(product);
        }
        [HttpPost]
        public IActionResult Post(AddProductInputModel model)
        {
            // Caso haja erros de validação, retornar BadRequest()
            var product = new Products(model.Title, model.Description, model.Price);

            _dbContext.Products.Add(product);

            return CreatedAtAction(nameof(GetByid), new { id = product.Id }, model);
        }

        // PuT para api/products{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProductInputModel model)
        {
            if (model.Description.Length > 50)
                return BadRequest();

            var product = _dbContext.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            product.Update(model.Description, model.Price);

            return NoContent();
        }
    }
}
