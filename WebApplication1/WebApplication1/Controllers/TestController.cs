using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("test/{id}")]

        Route("test/{id}")]

        public  IActionResult GetDetails(int id)
        {
            // Simulate fetching data based on the id
            var data = new { Id = id, Name = "Test Item", Description = "This is a test item." };
            // Return the data as JSON
           // return Json(data)

            return Ok(data);
        }
}
