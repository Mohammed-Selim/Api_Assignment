using DComtext;
using Domain;
using Dtos.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace myProjectApi.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Context context;
        public ProductController(Context _context)
        {
            this.context = _context;

        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var products = context.products;
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetAllProductByCategoryId(int id)
        {
            var products = context.categories
                .Include(cat => cat.Products).Where(cat => cat.ID == id)
                .Select(x => x.Products);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(Guid id)
        {
            var product = context.products.Find(id);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            var p = context.products.FirstOrDefault(c => c.ID == id);
            if (p == null)
            {
                return NotFound($"no category with id = {id}");
            }
            context.products.Remove(p);
            context.SaveChanges();
            return Ok("product was deleted...");
        }


        [HttpPut]
        public IActionResult UpdateCategory([FromBody] ProductDto p)
        {
            var pro = context.products.SingleOrDefault(c => c.ID == p.ID);
            if (pro == null)
            {
                return NotFound($"no product with id = {p.ID}");
            }
            pro.Name = p.Name;
            //context.Update(cat);
            context.SaveChanges();

            return Ok("category was updated...");
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductDto pro)
        {
            //var p = new product(pro.Name, pro.imageUrl, null, pro.Description
            //    , pro.Quantity, pro.Discount, pro.UnitWeight, pro.Price);
            var p = new product()
            {
                ID = pro.ID,
                Name = pro.Name,

            };

            context.products.Add(p);
            context.SaveChanges();
            return Ok(p);
        }
    }
}
