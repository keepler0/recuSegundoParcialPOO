using SegundoParcialBilleteraVirtual.Entidades;
using System.Runtime.CompilerServices;

namespace SegundoParcialBilleteraVirtual.Datos
{
	public class Billetera
	{
		private Dictionary<string, Moneda>? _monedas;
        
        public Billetera()
        {
            _monedas=new Dictionary<string, Moneda>();
        }
        public string Deposito(Moneda moneda)
        {
            string mensaje=string.Empty;
            if (moneda is null) throw new ArgumentException("Valor moneda fue null");
            if (_monedas!.ContainsKey(moneda.Codigo!))
            {
               string cant= _monedas[moneda.Codigo!].Cantidad.ToString();
				_monedas[moneda.Codigo!].Cantidad += moneda!.Cantidad;
                string nuevaCant= _monedas[moneda.Codigo!].Cantidad.ToString();
				mensaje = $"Se agrego la cantidad de {moneda.Codigo}, Antes: {cant}, Ahora: {nuevaCant}";
            }
            else
            {
                _monedas.Add(moneda.Codigo!, moneda);
                mensaje = $"Se agrego una nueva moneda:{moneda.Codigo} a la billetera";
            }
            return mensaje;
        }
        public List<Moneda>? MostrarContenido()
        {
            var lista=new List<Moneda>();
            foreach (var item in _monedas!)
            {
                lista.Add(item.Value!);
            }
            return lista;
        }
        public (bool,string) Retiro(Moneda moneda)
        {
            if (moneda is null) return (false, "Moneda con valor null");
            if (_monedas!.ContainsKey(moneda.Codigo!))
            {
                if (_monedas[moneda.Codigo!].Cantidad < moneda.Cantidad!) 
                    return (false, "La cantidad de seada del retiro de mayor al disponible");
				_monedas[moneda.Codigo!].Cantidad-= moneda.Cantidad;
			}
            else
            {
				return (false, "La moneda no existe en la billetera");
			}

            return (true, $"Se ha retirado {moneda.Cantidad} de la billetera. Saldo en billetera: {_monedas[moneda.Codigo!].Cantidad}");
        }
        public (bool,string) Pagar((string,decimal)datosPago)
        {
            string dato = datosPago.Item1;
            decimal valor=datosPago.Item2;
            if (_monedas!.ContainsKey("ARS") && _monedas["ARS"].Cantidad>=valor)
            {
                _monedas["ARS"].Cantidad -= valor;
                return (true, $"Datos de pago: {dato} monto: {valor}");
            }
			return (false,"No se pudo procesar el pago");
		}
    }
}
