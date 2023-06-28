using SEMANA14.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SEMANA14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e) { 
            List<Product> products = new List<Product>();
            for (int i = 0; i < 3; i++)
            {
                products.Add(new Product { Name = txtName.Text, Description = txtDescripcion.Text, Precio = txtPrecio, FechaVencimiento = txtFechaVencimiento });

                products.CreateRange()
                
            }
        }
    }
}
