using AspNetCoreIdentity.Extensions;
using AspNetCoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Controllers
{

    public class LogTesteController : Controller
    {
        private readonly ILogger<LogTesteController> _logger;

        public LogTesteController(ILogger<LogTesteController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogError("Erro aconteceu");
            return View();
        }
        
       
    }
}
