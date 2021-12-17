using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;
        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category { categoryId=1, Name="Bakery", description="Party Snacks"},
                new Category { categoryId=2, Name="Lunch", description="Wedding"},
                new Category { categoryId=3, Name="Dinner", description="Birthday"}
            };
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;   
        }

        public void AddCategory(Category category)
        {            
            if(categories.Any(x=>x.Name.Equals(category.Name,StringComparison.OrdinalIgnoreCase))) return;
            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.categoryId);
                category.categoryId = maxId + 1;
            }
            else
            {
                category.categoryId = 1;
            }
           
            categories.Add(category);
        }

        public Category GetCategoryById(int categoryId)
        {
           return categories?.FirstOrDefault(x => x.categoryId ==categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.categoryId);
            if (categoryToUpdate != null) categoryToUpdate = category;
        }
        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}
