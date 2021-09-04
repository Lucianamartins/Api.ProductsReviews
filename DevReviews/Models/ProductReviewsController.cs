using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReviews.Models
{
    [ApiController]
    [Route("api/{ProductId}/Productreviews")]
    public class ProductReviewsController : ControllerBase
    {
        [HttpGet("id")]
        public IActionResult GetByid(int productId, int id)
        {
            return Ok();

        }
        [HttpPost]
        public IActionResult  Post(int productid, AddProductReviewsInputModelClass model)
        {
            return CreatedAtAction(nameof(GetByid), new { id = 1, productId = 2 }, model); 
        }

    }
}
