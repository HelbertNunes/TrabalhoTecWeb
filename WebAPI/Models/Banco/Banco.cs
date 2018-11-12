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

		public static IEnumerable<Dieta> ObtemDietas(string idUsuario) =>
			_query.Select<Dieta>("SELECT * FROM Dieta WHERE IdUsuario = @idUsuario", new { idUsuario });

		public static Dieta RemoveDieta(string idDieta) =>
			_query.SelectExactlyOne<Dieta>("DELETE FROM Dieta WHERE Id = @idDieta", new { idDieta });

		public static Usuario ObtemUsuario(string email) =>
			_query.SelectExactlyOne<Usuario>("SELECT * FROM Usuario WHERE Email = @email", new { email });

		public static Usuario EditaUsuario(Usuario usuario) =>
			_query.SelectExactlyOne<Usuario>("UPDATE Usuario SET Nome = @Nome, Email = @Email, Senha = @Senha WHERE Id = @Id ", new { usuario });

		public static Usuario RemoveUsuario(Usuario usuario) =>
			_query.SelectExactlyOne<Usuario>("DELETE FROM Usuario WHERE Id = @Id", new { usuario });

		private static void InsereDieta(Dieta dieta) =>
			_query.SelectExactlyOne("INSERT INTO Dieta Values @dieta", new { dieta });

    }
}
