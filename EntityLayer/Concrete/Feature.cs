using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Feature
	{
		[Key]
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public bool Status { get; set; }
	}
}
