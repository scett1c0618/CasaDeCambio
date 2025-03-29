using Microsoft.AspNetCore.Mvc;
using CasaDeCambio.Models;

namespace CasaDeCambio.Controllers
{
    public class CambioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CalcularCambio(string monedaOrigen, string monedaDestino, decimal cantidad)
        {
            decimal tasaCambio = ObtenerTasaCambio(monedaOrigen, monedaDestino);
            decimal resultado = Math.Round(cantidad * tasaCambio, 2); 

            ViewBag.MonedaOrigen = monedaOrigen;
            ViewBag.MonedaDestino = monedaDestino;
            ViewBag.Cantidad = cantidad;
            ViewBag.Resultado = resultado;

            return View("Resultado");
        }


        private decimal ObtenerTasaCambio(string monedaOrigen, string monedaDestino)
        {
            decimal tasaCambio = 1.0m;

            if (monedaOrigen == "BRL" && monedaDestino == "PEN")
                tasaCambio = 0.6338236m;
            else if (monedaOrigen == "PEN" && monedaDestino == "BRL")
                tasaCambio = 1.577726m;

            return Math.Round(tasaCambio, 6);
        }


        

        
    }
}


