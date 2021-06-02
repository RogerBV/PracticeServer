using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Interfaces.Responses;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Implementation.SQL;
using Microsoft.AspNetCore.Hosting;
namespace PracticeServerFinal.Controllers
{
    public class PermitController : Controller
    {
        private IPermitService _permitService;
        private IPermitTypeService _permiteTypeService;
        private IWebHostEnvironment _hostingEnvironment;
        public PermitController(IWebHostEnvironment environment)
        {
            this._permitService = new PermitServiceSQL();
            this._permiteTypeService = new PermitTypeServiceSQL();
            _hostingEnvironment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            return Json(this._permitService.List());
        }
        [HttpGet]
        public IActionResult ListPermitTypes() 
        {
            return Json(this._permiteTypeService.List());
        }

        [HttpPost]
        public IActionResult SavePermit(CreatePermit createPermit)
        {
            return Json(this._permitService.Create(createPermit));
        }

    }
}
