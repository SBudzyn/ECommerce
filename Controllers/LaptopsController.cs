using ECommerce.Models;
using ECommerce.Models.Filters;
using ECommerce.Models.Response;
using ECommerce.Services;
using ECommerce.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopsController : ControllerBase
    {
        private RetrieveProductsService<Laptop, LaptopFullResponse, LaptopFilters> _retrieveService;
        IValidate<Review> _validator;
        private IPostReview _postReview;
        public LaptopsController(RetrieveProductsService<Laptop, LaptopFullResponse, LaptopFilters> retrieveService, IValidate<Review> validator, IPostReview postReview)
        {
            _retrieveService = retrieveService;
            _validator = validator;
            _postReview = postReview;
        }
        [HttpGet("{id:int}")]
        public ActionResult GetLaptop(int id)
        {
            var item = _retrieveService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(item);
            }
        }
        [HttpGet("{manufacturer?}")]
        public ActionResult GetLaptops([FromQuery] LaptopFilters filters)
        {
            var laptopsResult = _retrieveService.GetItems(filters);

            return Ok(laptopsResult);
        }
        //TEST!!!!!!!
        [HttpPost]
        [Route("PostResponse/{id}")]
        public ActionResult PostReview(int id, [FromBody] Review review)
        {
            //var phone = _retrieveService.GetById(id);
            //if (phone == null)
            //{
            //    return BadRequest();
            //}

            var validatedReview = _validator.Validate(review);
            if (validatedReview == null)
            {
                return BadRequest();
            }

            var isAdded = _postReview.PostReview(review);

            if (isAdded == true)
            {
                return CreatedAtAction(nameof(PostReview), review);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
