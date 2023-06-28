using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SEMANA14.Models
{
    public class Product
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public float Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
