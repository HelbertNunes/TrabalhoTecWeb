namespace WebAPI.Models
{
	public class Alimento
	{
		public int Id { get; set; }

		public string Nome { get; set; }

		public string Imagem { get; set; }

		public Macronutrientes Macronutrientes { get; set; }
	}
}
