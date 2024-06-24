using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Article
    {
        [Key]
        public int idArticle { get; set; }
        public string ArticleRef { get; set; }
        public string ArticleName { get; set; } = "";
        public string DescriptionArticle { get; set; } = "";
        public float PurchasePrice = 0;
        public float SellingPrice = 0;
        
        public int FamilyID { get; set; }
        [JsonIgnore]
        public Familly Familly { get; set; }
        public int StockQuantity { get; set; } = 0; // Added property
    }
}
