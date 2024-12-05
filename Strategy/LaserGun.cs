using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public  class LaserGun : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Вы стреляете из Лазерной Пушки! Лазерное Уничтожение ПИУ ПИУ ПИУ!!! выстрел.");
        }
    }
}
