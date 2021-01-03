using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CHAT_DOTNET_CRISATNO_LASSO_VACA.Models;
using CHAT_DOTNET_CRISATNO_LASSO_VACA.Hubs;

namespace CHAT_DOTNET_CRISATNO_LASSO_VACA.Controllers
{
    public class FilesController : Controller
    {
        private readonly ILogger<FilesController> _logger;

        public FilesController(ILogger<FilesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

      

        public IActionResult Inbox()
        {
            return View();
        }

    }
}