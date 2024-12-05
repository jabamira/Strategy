using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public  class Minigan : IWeapon
    {
        public void UseWeapon() 
        {
            Console.WriteLine("Вы стреляете из МИНИГАНА! ТУ ТУ ТУ ТУ ТУ ТУ ТУ ТУ ТУ ТУ УТ  ТУ ТУ ТУ");
        }
    }
}
