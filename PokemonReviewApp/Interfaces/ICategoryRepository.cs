using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        // read members
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);
        // create members
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);

        bool DeleteCategory(Category category);
        bool Save();
    }
}
