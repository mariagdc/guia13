using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2.Models
{
    internal class Controlador
    {
        public int[] CP;
        public int[] Pesosgr;
        public int[] EmpresaDistribucion;
        public double[] Pagos;
        public bool[] Certificadas;
        public int contador;



        public void Despachar(int cp, int Peso, int Empresa, bool Cert)//Agregar valores
        {

            CP[contador] = cp;
            Pesosgr[contador]= Peso;
            EmpresaDistribucion[contador]=Empresa;
            Certificadas[contador] = Cert;
                        
            contador++;
        }


    
    
        public int CantCorrespondencia()
        {

        }
        public double RecEmpresa()
        {

        } 
        public void CorrespEmpresa()
        {

        }

        public double RecTotal()
        {

        }
        public int TransMayorCorr()
        {


        }
        public void PrepararDistrib()
        {

        } 

    }

}
