// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace ProgettoPilotaiOsStoryBoard
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem addButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addButton != null) {
				addButton.Dispose ();
				addButton = null;
			}
		}
	}
}