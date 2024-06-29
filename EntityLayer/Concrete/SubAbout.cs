using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class SubAbout
	{
		[Key]
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
