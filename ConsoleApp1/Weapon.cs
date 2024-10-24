using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weapon
    {
        public string Name;
        public WeaponClass WeaponClass;
        public decimal Price;
        public Weapon(string name, WeaponClass weaponclass, decimal price)
        {
            Name = name;
            WeaponClass = weaponclass;
            Price = price;
        }
    }
}
