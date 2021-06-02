using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Services.Interfaces.Responses;
namespace PracticeServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermitController : ControllerBase
    {
        [HttpGet]
        public IActionResult List()
        {
            return Json(new List<RegisteredPermit>());
        }
    }
}
