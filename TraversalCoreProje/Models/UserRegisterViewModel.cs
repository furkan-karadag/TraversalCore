﻿using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı adınızı Giriniz")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen Mail Adresini Giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
		[Compare("Password", ErrorMessage = "Hatalı Şifre")]
		public string ConfirmPassword { get; set; }
		[Required(ErrorMessage = "Lütfen Cinsiyetinizi Giriniz")]
		public byte Gender { get; set; }

	}
}
