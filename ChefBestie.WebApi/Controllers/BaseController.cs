using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ChefBestie.WebApi.Controllers
{
    [ApiController]
    [Route("ChefBestieApi/[controller]/[action]")]
    [EnableCors("MyPolicy")]
    public class BaseController : ControllerBase
    {
        
    }
}
