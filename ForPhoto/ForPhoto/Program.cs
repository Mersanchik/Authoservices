using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPhoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceEntities entities = new ServiceEntities();
            foreach(var filtr in entities.Services) 
            {
                string path = @"H:\Рабочий стол\Работа 3\Задание\" + filtr.MainImagePath;
                byte[] imageInBytes = System.IO.File.ReadAllBytes(path);
                filtr.Photo = imageInBytes;
            }
            entities.SaveChanges();
        }
    }
}
