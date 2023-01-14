
namespace GTV.Mall.Models.ViewModel
{
    public class MenuViewModel
    {
        public string? Url { get; set; }
        public string? Text { get; set; }
        public IList<MenuViewModel>? SubMenu { get; set; }
    }
    public class MenuItem
    {
        public string? Id { get; set; }
        public string? LinkUrl { get; set; }
        public string? Text { get; set; }
    }
}
