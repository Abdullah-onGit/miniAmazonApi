using Microsoft.AspNetCore.Mvc;
using miniAmazonApi.Models;

namespace miniAmazonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserMasterController : ControllerBase
    {
        [HttpPost]
        public IActionResult create(UserMaster rec)
        {
            return CreatedAtAction("get", rec);
        }

    }
}