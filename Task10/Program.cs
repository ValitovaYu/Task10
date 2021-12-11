using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    /* Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
    Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных. 
    Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
    Создать объект на основе разработанного класса. Осуществить использование объекта в программе.*/
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(150,90,72);
            angle.ToRadians();
            Console.ReadKey();

        }
    }
    class Angle
    {
        // поля
        private int grad;
        private int min;
        private int sec;

        public int Grad
        {
            get
            {
                return grad;
            }
            set
            {
                if ((0<=value)&&(value <= 360))
                {
                 grad = value;
                }
                else
                {
                    Console.WriteLine("Угол должен быть в пределах от 0 до 360");
                }
                
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                min = value % 60;
                grad += value/60;
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                sec = value%60;
                min += value / 60;
            }
        }


        // конструктор для установки начальных значений       
        public Angle(int grad, int min, int sec)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }

        //метод ToRadians для перевода угла в радианы
        public void ToRadians()
        {
            double Gradus = grad + min / 60 + sec / 3600;
            double Radians = Gradus * (Math.PI / 180);
            Console.WriteLine("Угол в радианах = {0:F2}", Radians);
        }

    }
}
