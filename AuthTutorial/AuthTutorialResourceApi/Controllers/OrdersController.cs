using System.Linq;
using System.Security.Claims;
using AuthTutorialResourceApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthTutorialResourceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly BookStore _store;
        
        private int UserId => int.Parse(User.Claims.Single(c => c.Type == ClaimTypes.NameIdentifier).Value);

        public OrdersController(BookStore store)
        {
            _store = store;
        }
        
        [HttpGet]
        [Authorize (Roles = "User")]
        [Route("")]
        public IActionResult GetOrders()
        {
            if (!_store.Orders.ContainsKey(UserId)) return Ok(Enumerable.Empty<Book>());

            var orderedBookIds = _store.Orders.Single(o => o.Key == UserId).Value;
            var orderedBooks = _store.Books.Where(b => orderedBookIds.Contains(b.Id));

            return Ok(orderedBooks);
        }
    }
}