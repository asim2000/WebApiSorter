using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SortController : ControllerBase
    {
        [HttpPost]
        public IActionResult Sort([FromBody] int[] array,bool isAsc)
        {
            Sorter.Sort(array,isAsc);
            return Ok(array);
        }
    }
}
