using Newtonsoft.Json;

namespace ChefBestie.Domain
{
    public class User
    {
        public int Id { get; set; }
        public bool Admin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
               
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        /*
         * Without login:
         * - view recipes
         * - view coments
         * 
         * with login:
         * - can send a recipe for the Admin to validate
         * - Coment the recipes
         * - Rate the recipes (from 0 to 5)
         * - Have a personal area with their data
         * - Have a list of favourite recipes
         * 
         * Admin:
         * - Validate recipe 
         * - edit any recipe property
         * - block users 
        */

    }
}
