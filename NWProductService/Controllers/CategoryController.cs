using Microsoft.AspNetCore.Mvc;

namespace NWProductService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        [HttpGet(Name ="GetCategories")]
        public IEnumerable<Models.Category> GetCat()
        {
            Models.NorthwindContext cnt = new Models.NorthwindContext();
            return cnt.Categories;
        }
    }
}
