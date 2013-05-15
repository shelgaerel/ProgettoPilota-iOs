using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using CoreLibrary;
using DataListDataSourceiOs;

namespace ProgettoPilotaiOsStoryBoard
{
	public partial class RootViewController : UITableViewController
	{
		AreeDataListSource dataSource;

		public RootViewController (IntPtr handle) : base (handle)
		{
			// Custom initialization
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			//NavigationItem.LeftBarButtonItem = EditButtonItem;

			//var addButton = new UIBarButtonItem (UIBarButtonSystemItem.Add, AddNewItem);
			//NavigationItem.RightBarButtonItem = addButton;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			TableView.Source = dataSource = new AreeDataListSource ("areaCell");
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "SingleAreaSegue") { // set in Storyboard
				var navctlr = segue.DestinationViewController as AreeViewController;
				if (navctlr != null) {
					var source = TableView.Source as AreeDataListSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var item = source.GetItem(rowPath.Row);
					navctlr.LoadDataEntity (item); // to be defined on the TaskDetailViewController
				}
			}
		}
	}
}

