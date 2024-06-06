using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entites
{
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
