using System;
namespace JwtAuthenticationManager.Model
{
	public class AuthenticationResponseModel
	{
		//return token when user login successfully

		public string UserName { get; set; }
		public string Token { get; set; }
		//return when token expires
		public int ExpiresIn { get; set; }

	}
}

