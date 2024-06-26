using ChefBestie.Domain;
using ChefBestie.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChefBestie.WebApi.Controllers
{

    public class RecipeController : BaseController
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetAll()
        {
            return Ok(_recipeService.GetAll());
        }

        [HttpGet("by-id")]
        
        public ActionResult GetById(int id)
        {
            return Ok(_recipeService.GetById(id));
        }

        [HttpPost("add-update")]
        
        public ActionResult Post(Recipe recipe)
        {
            return Ok(_recipeService.Post(recipe));
        }

        [HttpDelete("by-id")]
        public void Remove(int id)
        {
            _recipeService.RemoveById(id);
        }

        [HttpGet("by-category")]
        [AllowAnonymous]
        public ActionResult GetByCategory(string category)
        {
            return Ok(_recipeService.GetByCategory(category));
        }
        
        [HttpGet("by-title")]
        [AllowAnonymous]
        public ActionResult GetByTitle(string title)
        {
            return Ok(_recipeService.GetByTitle(title));
        }

        [HttpGet("by-difficulty")]
        [AllowAnonymous]
        public ActionResult GetByDifficulty(string difficulty)
        {
            return Ok(_recipeService.GetByDifficulty(difficulty));
        }       

        [HttpGet("aprroved")]
        [AllowAnonymous]
        public ActionResult GetAllApproved()
        {
            return Ok(_recipeService.GetAllApproved());
        }

        //[HttpGet("Recipe-getbyingredient")]
        //public List<Recipe> GetByIngredient(string ingredient)

        //{
        //    return _recipeService.GetByIngredient(ingredient);
        //}



















    }
}
