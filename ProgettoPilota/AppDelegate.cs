using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ProgettoPilota
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			MainPageViewController viewController = new MainPageViewController();

			//---- instantiate a new navigation controller 
			var rootNavigationController = new UINavigationController(); 
			
			//---- add the home screen to the navigation controller 
			// (it'll be the top most screen) 
			rootNavigationController.PushViewController(viewController, false); 
			
			//---- set the root view controller on the window. the nav 
			// controller will handle the rest 
			this.window.RootViewController = rootNavigationController; 
			this.window.MakeKeyAndVisible (); 
			return true; 

			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

