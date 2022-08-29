using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FacadePattern
{
	public class SocialMediaShare
	{
		private FacebookShare facebook;
		private TwitterShare twitter;
		public SocialMediaShare(FacebookShare facebookShare, TwitterShare twitterShare)
		{
			this.facebook = facebookShare;
			this.twitter = twitterShare;
		}
		public void Share(string message)
		{
			this.facebook.SetMessage(message);
			this.twitter.SetMessage(message);
			this.facebook.Share();
			this.twitter.Share();
		}
	}
}
