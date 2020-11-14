using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ClubLlenoException : Exception
    {

        public ClubLlenoException()
            : base("Error. Club lleno de gimnasios.\n")
        {

        }

    }
}
