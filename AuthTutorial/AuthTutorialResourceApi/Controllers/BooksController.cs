using System.Linq;
using System.Security.Claims;
using AuthTutorialResourceApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthTutorialResourceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookStore _store;
        

        public BooksController(BookStore store)
        {
            _store = store;
        }
        
        [HttpGet]
        [Route("")]
        public IActionResult GetAvailableBooks()
        {
            return Ok(_store.Books);
        }

    }
}