namespace WebAPI.Models.Banco
{
	using QueryLibrary;
	using System.Collections.Generic;

	public static class Banco
    {
		private static Query _query = new Query("Server=tcp:fitlifeserver.database.windows.net,1433;Initial Catalog=FitLifeDB;Persist Security Info=False;User ID={USUARIO};Password={SENHA};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

		public static Alimento ObtemAlimento(Macronutrientes macronutrientes)
		{
			return _query.SelectExactlyOne<Alimento>(@"SELECT * FROM Alimento 
				WHERE (Gordura BETWEEN @Gordura AND @Gordura + 50) AND (Proteina BETWEEN @Proteina AND @Proteina + 50)
				AND (Carboidrato BETWEEN @Carboidrato AND @Carboidrato + 50)", macronutrientes);
		}

		public static IEnumerable<Dieta> ObtemDietas(string idUsuario) => new List<Dieta>();

		public static Dieta RemoveDieta(string idDieta) => new Dieta();

		public static Usuario ObtemUsuario(string emailUsuario) => new Usuario();

		public static Usuario EditaUsuario(Usuario usuario) => usuario;

		public static Usuario RemoveUsuario(Usuario usuario) => usuario;

    }
}
