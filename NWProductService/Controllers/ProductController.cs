using Microsoft.AspNetCore.Mvc;
using System.Collections;
namespace NWProductService.Controllers
{
    [ApiController]
    [Route("api/satis/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        [HttpGet(Name ="GetCategories")]
        public IEnumerable/*<Models.Category>*/ GetCat()
        {
            Models.NorthwindContext cnt = new Models.NorthwindContext();
            return cnt.Categories.Select(x => new { id = x.CategoryId, name = x.CategoryName});
        }

        [HttpGet("{categoryId}")]

        public IEnumerable GetByCategoryID(int categoryId)
        {
            Models.NorthwindContext cnt = new Models.NorthwindContext();
            return cnt.Products.Where(x => x.CategoryId == categoryId);
        }
    }
}
