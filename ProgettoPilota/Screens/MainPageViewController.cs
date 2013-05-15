using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.IO;
using Mono.Data.Sqlite;
using System.Data;
using CoreLibrary;

namespace ProgettoPilota
{
	public partial class MainPageViewController : UIViewController
	{
		AreeListViewController areeListViewController;

		public MainPageViewController () : base ("MainPageViewController", null)
		{
			this.Title = "Progetto Pilota";
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

			DeleteDatabaseIfItAlreadyExists();

			using (var conn= new SQLiteConnection(Options.GetDataBaseFilePath()))
			{
				conn.CreateTable<AreeEntity>();
			}
		}

		partial void btnAreeOnClick (NSObject sender)
		{
			if(this.areeListViewController == null)
			{ 
				this.areeListViewController = new AreeListViewController(); 
			}

			this.NavigationController.PushViewController(this.areeListViewController, true);

		}

		private void DeleteDatabaseIfItAlreadyExists()
		{
			var dbName = Options.GetDataBaseFilePath();
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var dbPath = Path.Combine(documents, dbName);
			
			if (File.Exists(dbPath))
			{
				File.Delete(dbPath);
			}
		}
	}
}

