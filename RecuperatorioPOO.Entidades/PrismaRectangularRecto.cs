using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioPOO.Entidades
{
	public class PrismaRectangularRecto
	{
		private int _Largo;
		private int _Altura;
		private int _Ancho;

		public PrismaRectangularRecto(int largo, int altura, int ancho)
		{
			if(ancho > 0 && altura > 0 && largo > 0)
	{
				_Largo = largo;
				_Altura = altura;
				_Ancho = ancho;
			}
			else
			{
				ancho++;
				altura++;
				largo++;
                string mensaje = "Las dimensiones deben ser mayores que cero.";
                throw new ArgumentException(mensaje);
                
			}
		}

		public int Ancho
		{
			get { return _Ancho; }
		}
		public int Altura
		{
			get { return _Altura; }
		}
		public int Largo
		{
			get { return _Largo; }
		}
		
		private double AreaBase() => _Largo * _Ancho;
		private double AreaAltura() => _Altura * _Ancho;
		private double AreaAncho() => _Altura * _Largo;
		public double Area()=>2*(AreaBase()+AreaAltura()+AreaAncho());
		public double Volumen() => _Largo * _Ancho * _Altura;
		public double Diagonal() => Math.Sqrt(Math.Pow(_Largo,2)+Math.Pow(_Ancho,2)+Math.Pow(_Altura,2));

		public string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append($"Area={ Area()}\n");
			sb.Append($"Volumen={ Volumen()}\n");
			sb.Append($"Diagonal={ Diagonal().ToString("N2")}\n");
			return sb.ToString();
		}
	}
}
