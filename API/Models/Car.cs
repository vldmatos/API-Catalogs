
namespace Catalog.Models
{
	public record Car
	{
		public Carmaker Carmaker { get; set; }

		public string Model { get; set; }

		public uint Year { get; set; }        
	}

	public enum Carmaker : short
	{
		Ford = 1,
		Chevrolet = 2,
		Fiat = 3,
		Volkswagen = 4,
		Hyndai = 5,
		Toyota = 6,
		Renault = 7,
		Peugeot = 8,
		Mercedes = 9,
		Volvo = 10,
		BMW = 11,
		Audi = 12,
		Jeep = 13
	}
}