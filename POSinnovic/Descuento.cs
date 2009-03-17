/* INNOVIC */
using System;
using System.Collections;
using System.Windows.Forms;

namespace POSinnovic
{
	public class Descuentos{
		private DescuentoTotal oDCTotal = new DescuentoTotal();
		private DescuentoLinea oDCLinea = new DescuentoLinea();
		
		public void addDesctoLinea(string Codigo, Int32 Valor){
			this.oDCLinea.AddDesctoImporte(Codigo, Valor);
		}

		public void addDesctoLinea(string Codigo, Single Valor){
			this.oDCLinea.AddDesctoPorcentaje(Codigo, Valor);
		}
		
		public Int32 GetDesctoLineaImp(string Codigo){
			return(this.oDCLinea.GetImporte (Codigo));
		}
		public Single GetDesctoLineaPor(string Codigo){
			return(this.oDCLinea.GetPorcentaje(Codigo));
		}
		
		public Int32 GetDesctoTotImp(){
			return(	this.oDCTotal.DescuentoImporte);
		}
		
		public Single GetDesctoTotPor(){
			return(this.oDCTotal.DescuentoPorcentaje);
		}
		
		public void DesctoTotal(Int32 Valor){
			this.oDCTotal.DescuentoImporte = Valor;
		}

		public void DesctoTotal(Single Valor){
			this.oDCTotal.DescuentoPorcentaje = Valor;
		}
	}
	
	public class DescuentoLinea
	{
		private SortedList DescuentoPorcentaje = new SortedList();
		private SortedList DescuentoImporte    = new SortedList();
		
		public void AddDesctoImporte( string Codigo, Int32 Valor ){
			if(DescuentoImporte.ContainsKey(Codigo)){
				this.DescuentoImporte[Codigo] = Valor;
			}else{
				this.DescuentoImporte.Add(Codigo,Valor);
			}
		}

		public void AddDesctoPorcentaje( string Codigo, Single Valor ){
			if(DescuentoPorcentaje.ContainsKey(Codigo)){
				DescuentoPorcentaje[Codigo] = Valor;
			}else{
				DescuentoPorcentaje.Add(Codigo,Valor);
			}
		}
		
		public Single GetPorcentaje(string Codigo){
			Single Salida = 0;
			if(DescuentoPorcentaje.ContainsKey(Codigo)){
				Salida = (Single)DescuentoPorcentaje[Codigo];
			}
			return ( Salida );
		}
		
		public Int32 GetImporte(string Codigo){
			Int32 Salida = 0;
			if(DescuentoImporte.ContainsKey(Codigo)){
				Salida = (int)DescuentoImporte[Codigo];
			}
			return(Salida);
		}
	}

	public class DescuentoTotal
	{
		public Int32  DescuentoImporte    = 0;
		public Single DescuentoPorcentaje = 0;
	}
}
