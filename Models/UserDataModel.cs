using Microsoft.AspNetCore.Mvc.Diagnostics;
using System;
using System.ComponentModel.DataAnnotations;


namespace Social_core_exended.Models
{
    public class UserDataModel
    {
		public int id { get; set; }

		[Required]
		[StringLength(256, MinimumLength = 3)]
		public string email { get; set; }

		[Required]
		[RegularExpression(@"^[a-zA-Z _\-\s\d]{1,30}$")]

		public string login { get; set; }

		[Required]
		[RegularExpression(@"^[a-zA-Z _\-\s\d]{8,16}$")]

		public string password { get; set; }

		[Required]

		public string avatars { get; set; }
	}
}
