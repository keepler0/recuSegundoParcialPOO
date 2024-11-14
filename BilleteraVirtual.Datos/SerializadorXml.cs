using SegundoParcialBilleteraVirtual.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SegundoParcialBilleteraVirtual.Datos
{
    public class SerializadorXml:IArchivo<List<Moneda>>
    {
		private string nombreArchivo = "Almacen.xml";
		private string nombreCarpeta = "DatosAlmacen";
		private string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;
		public SerializadorXml()
		{

		}
		public void GuardarDatos(List<Moneda>lista)
		{
			var rutaCarpeta = Path.Combine(rutaProyecto, nombreCarpeta);
			if (!Directory.Exists(rutaCarpeta))
			{
				Directory.CreateDirectory(rutaCarpeta);
			}
			var rutaArchivo = Path.Combine(rutaProyecto, nombreCarpeta, nombreArchivo);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Moneda>));
			using (var escritor = new StreamWriter(rutaArchivo))
			{
				xmlSerializer.Serialize(escritor, lista);
			}
		}

		public List<Moneda> LeerDatos()
		{
			var rutaArchivo = Path.Combine(rutaProyecto, nombreCarpeta, nombreArchivo);
			if (!File.Exists(rutaArchivo))
			{
				return new List<Moneda>();
			}
			using (var lector = new StreamReader(rutaArchivo))
			{
				var xmlSerializer = new XmlSerializer(typeof(List<Moneda>));
				return xmlSerializer.Deserialize(lector!) as List<Moneda>;
			}
		}
	}
}
