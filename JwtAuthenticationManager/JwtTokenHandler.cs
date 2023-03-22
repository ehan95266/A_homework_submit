using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthenticationManager.Model;
using Microsoft.IdentityModel.Tokens;

namespace JwtAuthenticationManager
{
	public class JwtTokenHandler
	{
		//write your own secret key, any meaningful text
		public const string JWT_Secret_Key = "IamUsingThisKeyAsJWTSecretKeyForSecurityIn2023";
		// set token valid time, expire after 20 mins
		public const int JWT_Token_Valid_Mins = 20;

		//create list of user account(just for example)
		private readonly List<UserAccount> accounts;

		public JwtTokenHandler()
		{
			accounts = new List<UserAccount>
			{
				new UserAccount(){ Username="admin", Password="admin@1234", Role="Admin"},
                new UserAccount(){ Username="yitong", Password="yitong@1234", Role="User"},
                new UserAccount(){ Username="scott", Password="scott@1234", Role="Manager"}
            };
		}

		//verify the login is correct or not
		//call this method in api 
		public AuthenticationResponseModel GenerateJwtToken(AuthenticationRequestModel authenticationRequestModel) {
			if (authenticationRequestModel == null)
				return null;
			if (string.IsNullOrEmpty(authenticationRequestModel.Username) || string.IsNullOrEmpty(authenticationRequestModel.Password))
				return null;

			var accountinfo = accounts.Where(x => x.Username == authenticationRequestModel.Username && x.Password == authenticationRequestModel.Password).FirstOrDefault();
			if (accountinfo == null)
				return null;

			/*code for jwt token generation*/
			//first check in database a user credential is valid or not
			//second if login valid then generate token
			//valid for 20minutes from when token generated

			var toeknExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_Token_Valid_Mins);
			var tokenKey = Encoding.ASCII.GetBytes(JWT_Secret_Key);

			var claminUserIdentity = new ClaimsIdentity(
				new List<Claim>
				{
					new Claim(JwtRegisteredClaimNames.Name, authenticationRequestModel.Username),
					new Claim(ClaimTypes.Role,accountinfo.Role)
				});

			//convert secret key into encrypted value --> create signin credential
			var signInCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey),
				SecurityAlgorithms.HmacSha256Signature
                );

			var securityTokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = claminUserIdentity,
				Expires = toeknExpiryTimeStamp,
				SigningCredentials = signInCredentials
			};

			var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
			var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

			var tokenString = jwtSecurityTokenHandler.WriteToken(securityToken);

			//create object of reponse model

			return new AuthenticationResponseModel
			{
				UserName = authenticationRequestModel.Username,
				ExpiresIn = (int)toeknExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds,
				Token = tokenString
			};
				
        }

    }
}

