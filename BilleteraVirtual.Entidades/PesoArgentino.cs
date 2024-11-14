using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialBilleteraVirtual.Entidades
{
	public class PesoArgentino : Moneda
	{
		private static decimal _valorEnDolares;
		private static decimal _valorEnEuros;
		private static decimal _valorEnYuanes;
		static PesoArgentino()
		{
			_valorEnDolares = 0.0028571428571429m;
			_valorEnEuros= 0.0027027027027027m;
			_valorEnYuanes= 0.02m;
		}

		public PesoArgentino(decimal cantidad) : base(cantidad, "ARG", "$")
		{
		}
		public override Moneda Convertir(Type moneda)
		{
			//var tipo = moneda.GetType().Name;
			//switch (tipo)
			//{
			//	case "Yuan":
			//		return new Yuan();
			//	default:
			//		break;
			//}
			throw new NotImplementedException();
		}
	}
}
