namespace WebAPI.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Collections.Generic;
	using WebAPI.Models;
	using WebAPI.Models.Banco;
	using WebAPI.Models.Calculo;

	[Route("api/[controller]")]
	public class DietaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public Dieta Post(Macronutrientes macronutrientes) => Calculador.GeraDieta(macronutrientes);

		[HttpGet]
		public IEnumerable<Dieta> Get(string idUsuario) => Banco.ObtemDietas(idUsuario);

		[HttpDelete]
		public Dieta Delete(string idDieta) => Banco.RemoveDieta(idDieta);
	}
}