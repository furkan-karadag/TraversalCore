using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class About
	{
		[Key]
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image1 { get; set; }
		public string Title2 { get; set; }
		public string Decription2 { get; set; }
		public bool Status { get; set; }
	}
}
