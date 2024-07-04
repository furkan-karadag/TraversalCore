using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
	public class AppUser : IdentityUser<int>
	{
		public string? ImageUrl { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public byte Gender { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
