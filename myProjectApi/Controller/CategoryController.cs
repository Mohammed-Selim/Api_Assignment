using Application.Features.Categories.Commands.CreaateCategory;
using Application.Features.Categories.Commands.DeleteCategory;
using Application.Features.Categories.Commands.UpdateCategory;
using Application.Features.Categories.Queries.CategoryDetailes;
using Application.Features.Categories.Queries.GetAllCategories;
using DComtext;
using Domain;
using Dtos.category;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace myProjectApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly Context context;
        private readonly IMediator Med;
        public CategoryController(Context _context, IMediator _med)
        {
            context = _context;
            Med = _med;
        }
        [HttpGet("asd")]
        
        public async Task< IActionResult> GetAllCategories([FromQuery] GetAllCategoriesquery q)
        {
            return  Ok(await Med.Send(q));
            //var categories = context.categories;
            //return Ok(categories);
        }

        //[HttpGet]
        //public IActionResult GetAllCategories()
        //{
        //    return Ok(Med.Send(new GetAllCategoriesquery()));
        //}


        [HttpGet]
        public async Task< IActionResult> GetCategoryById([FromBody]GetCategoryById q)
        {
          //  var Category = context.categories.Find(id);
         // var Category = await Med.Send(q);
            return  Ok(await Med.Send(q));
        }

        [HttpDelete]
        public async Task< IActionResult> DeleteCategory([FromBody]DeleteCategoryCommand q)
        {
            return  Ok(await Med.Send(q));
            //var Category = context.categories.SingleOrDefault(c => c.ID == id);//(c=>c.ID== id);
            //if (Category == null)
            //{
            //    return NotFound($"no category with id = {id}");
            //}
            //context.categories.Remove(Category);
            //context.SaveChanges();
            //return Ok("category was deleted...");

        }

        [HttpPut]
        public async Task< IActionResult> UpdateCategory([FromBody] UpdateCategoryCommand q)
        {
            return Ok(await Med.Send(q));
            //var Category = context.categories.FirstOrDefault(c => c.ID == id);
            //if (Category == null)
            //{
            //    return NotFound($"no category with id = {cat.ID}");
            //}
            //Category.Name = cat.Name;
            ////context.Update(cat);
            //context.SaveChanges();

            //return Ok("category was Updated...");
        }

        [HttpPost]
        public async Task< IActionResult> CreateCategory([FromBody] CeateCategoryCommand q)
        {
            //var Category = new category() { Name = cat.Name, Description = cat.Description };

            //context.categories.Add(Category);
            //context.SaveChanges();
            //return Ok(Category);
            return Ok(await Med.Send(q));
        }
    }
}
