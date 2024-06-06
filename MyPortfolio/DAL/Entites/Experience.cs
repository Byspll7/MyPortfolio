using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entites
{
	public class Experience
	{
        [Key]
        public int ExperianceID { get; set; }
        public string Head { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }



    }
}
