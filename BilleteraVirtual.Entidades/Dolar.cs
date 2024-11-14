using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialBilleteraVirtual.Entidades
{
	public class Dolar : Moneda
	{
		private decimal _valorEnPesos;
		public Dolar()
		{
		}

		public Dolar(decimal cantidad) : base(cantidad,"USD", "U$D")
		{
			_valorEnPesos = 350;
		}

		public override Moneda Convertir(Type? moneda)
		{
			throw new NotImplementedException();
		}
	}
}
