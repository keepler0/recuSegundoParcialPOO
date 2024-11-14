

namespace SegundoParcialBilleteraVirtual.Entidades
{
	public class Euro : Moneda
	{
		private decimal _valorEnDolares;
		private decimal _valorEnPesos;
		public Euro()
		{
			_valorEnPesos = 370;
			_valorEnDolares = 0.94m;
		}

		public Euro(decimal cantidad) : base(cantidad,"EUR" , "€")
		{
		}

		public override Moneda Convertir(Type moneda)
		{
			throw new NotImplementedException();
		}
	}
}
