using Excepciones;
using System.Text;

namespace Entidades
{
    public class Mancuerna : ElementosGimnasio
    {

      

        public Mancuerna()
            : base()
        {

        }
        public Mancuerna(int peso):base(peso)
        {

        }
        public Mancuerna(int id, int peso) : base(id, "mancuerna", peso, 0)
        {
            


        }

        //private int ValidarPeso(int peso)
        //{

        //    int validado = 0;

        //    if (int.TryParse(peso.ToString(), out validado))
        //    {


        //        if (peso > 0 && peso <= 2)
        //        {
        //            this.Precio = 1000;
        //        }
        //        else if (peso >= 3 && peso <= 5)
        //        {
        //            this.Precio = 2000;
        //        }
        //        else if (peso >= 6 && peso <= 10)
        //        {
        //            this.Precio = 5000;
        //        }
        //    }
        //    else
        //    {
        //        throw new PesoInvalidoException();
        //    }


        //    return validado;

        //}

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendFormat($"Mancuerna de : {this.Caracteristica} KGs.\n");



            return sb.ToString();

        }


        public override string ToString()
        {
            return this.MostrarDatos();

        }
    }
}




