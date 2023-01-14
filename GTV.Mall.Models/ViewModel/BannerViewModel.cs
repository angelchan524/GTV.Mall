
namespace GTV.Mall.Models.ViewModel
{
    /// <summary>
    ///  Banner
    /// </summary>
    public class Banner
    {
        public IList<BannerItem> Items { get; set; }
            = new List<BannerItem>();
        public Banner() { }
    }
    public class BannerItem
    {
        public string Name { get; set; }
        public string PostUrl { get; set; }
        public string ImageUrl { get; set; }

    }
}
