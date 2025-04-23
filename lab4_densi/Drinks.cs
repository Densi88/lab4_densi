using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_densi
{
    public class Drinks
    {
        private double size;
    }
    public class Juice : Drinks 
    {
        private bool pulp;
        private String fruit="";

    }
    public class Soda : Drinks
    {
        private int countOfBubles = 0;
        private string type = "";

    }
    public class Alco : Drinks
    {
        private int ProccentOfStrength = 0;
        private string type = "";
    }
}
