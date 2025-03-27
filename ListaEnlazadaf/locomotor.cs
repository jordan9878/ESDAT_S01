using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaf
{
    class locomotor
    {
        vagon Primero { get; set; }
        public void AgregaPrimero(int valor)
        {
            vagon nuevo = new vagon(valor);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                nuevo.Sig = this.Primero;
                vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
            public void AgregaFinal(int valor)
        {
            vagon nuevo = new vagon(valor);
            if(this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
            public string VerVagones()
        {
            string listaVag = "";
            vagon tmp = this.Primero;
            while (tmp != null)
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }

            return listaVag;
        }
    }
}
