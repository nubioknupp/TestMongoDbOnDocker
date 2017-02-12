using System;
using MongoDB.Bson;

namespace TestMongoDb
{
	public class Cidade
	{
		public ObjectId _id { get; set; }
		public string Nome { get; set; }
		public string Estado { get; set; }
		public string Pais { get; set; }
	}
}
