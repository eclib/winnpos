/* INNOVIC */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient; 
using System.Windows.Forms;
using System.Management;
using Negocio;
using Rutinas;

namespace POSinnovic
{
	/// <summary>
	/// Objeto de Descuento.
	/// </summary>
	public class Descuento
	{
		public DataGridView grilla;
		public int		lin;							// Linea Seleccionada.
		public string[] DesctTipo	= new string[50];	// Tipo de Descuento de la linea.
		public string[] DesctCodigo	= new string[50];	// Codigo de la linea.
		public int[]	DesctValor	= new int[50];		// Valor de Descuento de la linea.
		
		FormDescuento Desct1 = new FormDescuento();		
		
		public Descuento()
		{
		}

		/// <summary>
		/// Metodo para iniciar el descuento manual.
		/// </summary>
		public void Descto(){
			// Se crea el objeto para el ingreso de descuento manual.
			Desct1.grilla		= this.grilla;
			Desct1.ShowDialog();
			lin					= this.grilla.CurrentRow.Index;
			DesctTipo[lin]		= Desct1.TipoDesct.ToString();
			DesctCodigo[lin]	= Desct1.CodigoDesct.ToString();
			DesctValor[lin]		= Desct1.ValorDesct;
		}

		/// <summary>
		/// Metodo para obtener el Tipo de Descuento de la linea.
		/// </summary>
		public string obtenerTipo(int indice){
			return DesctTipo[indice];
		}

		/// <summary>
		/// Metodo para obtener el Codigo de la linea.
		/// </summary>		
		public string obtenerCodigo(int indice){
			return DesctCodigo[indice];		
		}

		/// <summary>
		/// Metodo para obtener el Valor del Descuento de la linea.
		/// </summary>
		public int obtenerDesct(int indice){
			return DesctValor[indice];		
		}
	}
}
