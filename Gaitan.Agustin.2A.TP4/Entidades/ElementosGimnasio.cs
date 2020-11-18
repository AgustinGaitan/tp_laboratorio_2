using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ElementosGimnasio
    {
        protected int precio;
        protected int caracteristica;

        public int Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public int Caracteristica
        {
            get
            {
                return this.caracteristica;
            }
            set
            {
              
                 this.caracteristica = value;
             
                   
            }
        }


        public ElementosGimnasio()
        {
            this.Precio = precio;

        }

    }
}
