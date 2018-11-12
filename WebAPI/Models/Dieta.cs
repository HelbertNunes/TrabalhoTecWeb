namespace WebAPI.Models
{
	using System.Collections.Generic;

	public class Dieta
    {
		public string Id { get; set; }

		public Usuario Usuario { get; set; }

		public IEnumerable<Alimento> Alimentos { get; set; }

		public string Nome { get; set; }
	}
}
