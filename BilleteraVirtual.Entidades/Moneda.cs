using System.Xml.Serialization;

namespace SegundoParcialBilleteraVirtual.Entidades
{
	[XmlInclude(typeof(Yuan))]
	[XmlInclude(typeof(Euro))]
	[XmlInclude(typeof(Dolar))]
	[XmlInclude(typeof(PesoArgentino))]

	public abstract class Moneda
	{
		private decimal _cantidad;
		private string? _codigo;
		private string? _simbolo;

		protected Moneda()
		{

		}
		protected Moneda(decimal cantidad, string? codigo, string? simbolo)
		{
			_cantidad = cantidad;
			_codigo = codigo;
			_simbolo = simbolo;
		}

		public string? Simbolo
		{
			get { return _simbolo; }
			set
			{
				_simbolo = value is not null ? value :
							 throw new Exception("Error, Simbolo con valor null");
			}
		}


		public string? Codigo
		{
			get { return _codigo; }
			set
			{
				_codigo = value is not null ? value :
							throw new Exception("Error, Codigo con valor null");
			}
		}


		public decimal Cantidad
		{
			get { return _cantidad; }
			set
			{
				_cantidad = value > 0 ? value :
							  throw new Exception("Error, la cantidad no puede ser menor a cero");
			}
		}

		public abstract Moneda Convertir(Type moneda);
		public override string ToString()
		{
			return $"Codigo: {Codigo}- Simbolo: {Simbolo}- Cantidad: {Cantidad}";
		}
	}
}
