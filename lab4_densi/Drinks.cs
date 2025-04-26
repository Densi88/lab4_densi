using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_densi
{
    public class Drinks
    {
        public double size;
        public virtual string GetInfo()
        {
            string result = "";
            result += String.Format("\nОбъем(Л){0}", this.size);
            return result;
        }
    }
    public class Juice : Drinks 
    {
        private bool pulp;
        private String fruit="";

        public static Juice Generate()
        {
            var rnd = new Random();
            var number = rnd.Next() % 3;
            var result = "";
            switch (number)
            {
                case 0:
                    result = "Апельсин";
                    break;
                case 1:
                    result = "Яблоко";
                    break;
                case 2:
                    result = "Томат";
                    break;
            }
            return new Juice
            {
                size = rnd.Next() % 5,
                pulp = rnd.Next() % 2 == 0, // наличие листика true или false
                fruit = result,
            };
        }

        public override string GetInfo()
        {
            string result = "Я сок";
            result += base.GetInfo();
            result+= String.Format("\nНаличие мякоти: {0}", this.pulp);
            result += String.Format("\nФрукт: {0}", this.fruit);
            return result;

        }

    }
    public class Soda : Drinks
    {
        private int countOfBubles = 0;
        private string type = "";

        public override string GetInfo()
        {
            string result = "Я газировка";
            result += base.GetInfo();
            result += String.Format("\nКоличество пузырей: {0}", this.countOfBubles);
            result += String.Format("\nТип: {0}", this.type);
            return result;

        }
        public static Soda Generate()
        {
            var rnd = new Random();
            var number = rnd.Next() % 3;
            var result = "";
            switch (number)
            {
                case 0:
                    result = "Кола";
                    break;
                case 1:
                    result = "Фанта";
                    break;
                case 2:
                    result = "Буратино";
                    break;
            }
            return new Soda
            {
                size = rnd.Next() % 5,
                countOfBubles = rnd.Next() % 10000,
                type = result,
            };
        }

    }
    public class Alco : Drinks
    {
        private int proccentOfStrength = 0;
        private string type = "";

        public override string GetInfo()
        {
            string result = "Я алкоголь";
            result += base.GetInfo();
            result += String.Format("\nКрепость(%): {0}", this.proccentOfStrength);
            result += String.Format("\nТип: {0}", this.type);
            return result;

        }
        public static Alco Generate()
        {
            var rnd = new Random();
            var number = rnd.Next() % 3;
            var result = "";
            switch (number)
            {
                case 0:
                    result = "Пиво";
                    break;
                case 1:
                    result = "Сидр";
                    break;
                case 2:
                    result = "Вино";
                    break;
            }
            return new Alco
            {
                size = rnd.Next() % 5,
                proccentOfStrength = rnd.Next() % 20,
                type = result,
            };
        }
    }
}
