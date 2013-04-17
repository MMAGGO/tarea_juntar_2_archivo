using System;
using System.IO;

namespace archivos
{
	class Principal
	{
		public static void Main (string[] args)
		{


			Archivo archivo3 = new Archivo ("union.txt");

		
			archivo3.aderir ();
			archivo3.leer ();
			archivo3.aderir ();
			archivo3.leer ();

}
	}
}

