using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    public class Service
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }

        public override string ToString()
        {
            return $"Название услуги: {Name}, цена: {Price}, дата: {Date}";
        }
    }
}
