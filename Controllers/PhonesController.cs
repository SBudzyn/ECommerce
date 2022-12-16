using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Services;
using ECommerce.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private RetrieveProductsService<Phone, PhoneFullResponse, PhoneFilters> _retrieveService;
        private IPostReview _postReview;
        public PhonesController(RetrieveProductsService<Phone, PhoneFullResponse, PhoneFilters> retrieveService, IValidate<Review> validator, IPostReview postReview)
        {
            _retrieveService = retrieveService;
            _postReview = postReview;
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPhone(int id)
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
        public ActionResult GetPhones([FromQuery] PhoneFilters filters)
        {           
            var phonesResult = _retrieveService.GetItems(filters);

            return Ok(phonesResult);
        }
        //TEST!!!!!!!
        [HttpPost]
        [Route("PostResponse/{id}")]
        public ActionResult PostReview(int id, [FromBody] Review review)
        {
            bool result = _postReview.PostReview(review);
            if (result == false)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(PostReview), review);

        }
        
    }
}
