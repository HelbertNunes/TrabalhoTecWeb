namespace WebAPI.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using WebAPI.Models;
	using WebAPI.Models.Banco;

	[Route("api/[controller]")]
	public class UsuarioController : Controller
    {
		[HttpPost]
		public ObjectResult Post(string email, string senha)
		{
			var usuario = Banco.ObtemUsuario(email);

			if (usuario is null) return NotFound("Usuário nao encontrado");

			if (usuario.Senha == senha)
			{
				Redirect("/home");
				return Ok(true);
			}
			else
				return Ok(false);

		}

		[HttpPut]
		public Usuario Put(Usuario usuario) => Banco.EditaUsuario(usuario);

		[HttpDelete]
		public Usuario Delete(Usuario usuario) => Banco.RemoveUsuario(usuario);
	}
}