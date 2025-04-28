using Microsoft.AspNetCore.Mvc;


namespace Controllers{
    [ApiController]
    [Route("api/categories")]

    public class CategoryController: ControllerBase{
        private readonly AppDbContext _Context;
        public CategoryController(AppDbContext context){
            _context = context; 
            //tạo mới danh mục
        [HttpPost]
        public async Task<ActionResult<Category>> 
            CreatCategory([FromBody] CategoryRequest request)
            try{
                var category = new Category{
                    Name = request.Name,
                    Description = request.Description
                };
                _context.categories.Add(category);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCategory),
                                      new {id = category.Id}, category );

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
    class CategoryRequest{
        public string Name {get; set;}
        public string? Description {get; set;}
    }
}