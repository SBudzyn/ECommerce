using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Models.Response;
using ECommerce.Services;
using ECommerce.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgesController : ControllerBase
    {
        private RetrieveProductsService<Fridge, FridgeFullResponse, FridgeFilters> _retrieveService;
        IValidate<Review> _validator;
        private IPostReview _postReview;
        public FridgesController(RetrieveProductsService<Fridge, FridgeFullResponse, FridgeFilters> retrieveService, IValidate<Review> validator, IPostReview postReview)
        {
            _retrieveService = retrieveService;
            _validator = validator;
            _postReview = postReview;
        }
        [HttpGet("{id:int}")]
        public ActionResult GetFridge(int id)
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
        public ActionResult GetFridges([FromQuery] FridgeFilters filters)
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
