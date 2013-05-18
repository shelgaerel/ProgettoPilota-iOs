using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ProgettoPilotaiOsStoryBoard
{
	public partial class MenuTableViewCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("MenuTableViewCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("MenuTableViewCell");

		public MenuTableViewCell (IntPtr handle) : base (handle)
		{
		}

		public static MenuTableViewCell Create ()
		{
			return (MenuTableViewCell)Nib.Instantiate (null, null) [0];
		}

		partial void ButtonClick (NSObject sender)
		{

		}
	}
}

