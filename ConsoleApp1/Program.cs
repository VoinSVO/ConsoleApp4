using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> weapons = new List<Weapon>()
            {
                new Weapon("Pistols", WeaponClass.Ranged, 100.99m),
                new Weapon("RPG", WeaponClass.Missile, 150.99m),
                new Weapon("Sword", WeaponClass.Melee, 55.99m),
                new Weapon("Staff", WeaponClass.Magic, 75.99m),
                new Weapon("Grenade", WeaponClass.Explosive, 80.99m)
            };
            Dictionary<WeaponClass, (int totalSales, decimal totalRevenue)> saleReport = new Dictionary<WeaponClass, (int totalSales, decimal totalRevenue)>();
            
            foreach (var weaponclass in Enum,GetValues(typeof(WeaponClass)))
            {
                salesReport[(WeaponClass)weaponclass] = (0, 0);
            }

            int[,] fixedSales = new int[,]
            {
                { 3, 2, 1 },
                { 2, 3, 2 },
                { 1, 1, 0 },
                { 0, 2, 1 },
                { 1, 1, 1 }
            };

            for (int day = 0; day < 3; day++)
            {
                foreach (var weapon in weapons)
                {
                    int weaponclassIndex = (int)
                }
            }
        }
    }
}
