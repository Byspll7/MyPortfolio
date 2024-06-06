using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entites
{
    public class SocialMedia
    {
        [Key]
        public int SocialMedaiID { get; set; }
        public string Ttile { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }





    }
}
