using SEMANA14.DataContext;
using SEMANA14.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEMANA14
{
    public class ProductService
    {
        private readonly AppDbContext _context;
        public ProductService() => _context = App.GetContext();

        public bool Create(Product item)
        {
            try
            {
                _context.Products.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false; }
        }
        public bool CreateRange(List<Product> items)
        {
            try
            {
                _context.Products.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Product> GetByText(string text) 
        {
            return _context.Products.Where(x => x.Name.Contains(text)).ToList();
        }
    }
}
