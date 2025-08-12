using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.APILayer.DataAccess.Entity
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}
