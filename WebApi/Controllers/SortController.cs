using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SortController : ControllerBase
    {
        [HttpPost]
        public IActionResult Sort([FromBody] int[] array)
        {
            Sorter.Sort(array);
            return Ok(array);
        }
    }
}
