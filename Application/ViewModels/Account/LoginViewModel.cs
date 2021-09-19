namespace ViewModels.Account
{
	public class LoginViewModel : object
	{
		public LoginViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Remember me?")]
		public bool RememberMe { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Password")]
		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Required]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Email Address")]
		[System.ComponentModel.DataAnnotations.EmailAddress]
		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		[System.ComponentModel.DataAnnotations.Required]
		public string EmailAddress { get; set; }
		// **********
	}
}
