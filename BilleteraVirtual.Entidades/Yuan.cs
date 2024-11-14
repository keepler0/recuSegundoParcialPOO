
namespace SegundoParcialBilleteraVirtual.Entidades
{
	public class Yuan : Moneda
	{
		private decimal _valorEnDolares;
		private decimal _valorEnPesos;
		public Yuan()
		{
			_valorEnDolares= 0.1408450704225352m;
			_valorEnPesos = 50m;
		}

		public Yuan(decimal cantidad) : base(cantidad, "CNY", "¥")
		{
		}

		public override Moneda Convertir(Type moneda)
		{
			throw new NotImplementedException();
		}
	}
}
