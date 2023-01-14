using GTV.Mall.Models.DataModel;

namespace GTV.Mall.Models.ViewModel
{
    public class CategoryMenuViewModel: MenuViewModel
    {
        private Category? Category { get; set; }
        public IList<CategoryMenuViewModel>? SubMenu { get; set; }
        public CategoryMenuViewModel() { }
        public CategoryMenuViewModel(Category category)
        {
            Url = "";
            Text = category.Name;
            Category = category;
        }
    }
}
