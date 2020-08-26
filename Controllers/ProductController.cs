using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnOnePageVuejs.Data;
using OnOnePageVuejs.Models;

namespace OnOnePageVuejs.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _environment;
        public ProductController(AppDbContext context ,IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.products.ToList());
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            var prd = _context.products.Find(product.Id);
            prd.Name = product.Name;
            prd.Description = product.Description;
            prd.UrlPhoto = product.UrlPhoto;
            prd.Price = product.Price;
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create( Product product)
        {
           
            product.CreateDate = DateTime.Now;
            _context.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpDelete]
        public IActionResult DeleteProduct(Product product)
        {
            var deleted = _context.products.Find(product.Id);
            _context.Remove(deleted);
            _context.SaveChanges();
            return Ok();
        }

     
    }
}