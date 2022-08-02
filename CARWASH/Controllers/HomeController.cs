using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CARWASH.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CARWASH.Controllers
{
    public class HomeController : Controller
    {
        private readonly CARWASHContext _CARWASH;

        public HomeController(CARWASHContext context)
        {
            _CARWASH = context;
        }

        public IActionResult Index()
        {
           List<Empleado> lista= _CARWASH.Empleados.ToList();

            Console.WriteLine(lista.ToString());
            return View();
        }

    }
}