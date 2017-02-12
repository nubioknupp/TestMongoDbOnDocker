using System;
using MongoDB.Driver;

namespace TestMongoDb
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string connectionString = "mongodb://192.168.99.100:32769";

			var client = new MongoClient(connectionString);
			var db = client.GetDatabase("TestMongoDb");

			var cidades = db.GetCollection<Cidade>("cidades");

			var cidade = new Cidade();
			cidade.Nome = "Juiz de Fora";
			cidade.Estado = "Minas Gerais";
			cidade.Pais = "Brasil";

			cidades.InsertOne(cidade);

			Console.WriteLine(cidade._id);

		}
	}
}