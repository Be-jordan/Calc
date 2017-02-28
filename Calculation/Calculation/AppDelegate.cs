using Foundation;
using UIKit;

namespace Calculation
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window
		{
			get;
			set;
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method

			Window = new UIWindow(UIScreen.MainScreen.Bounds);

			var controller = new UIViewController();

			controller.View.BackgroundColor = UIColor.White;

			controller.Title = "My Controller";

			Window.RootViewController = controller;

			// make the window visible
			Window.MakeKeyAndVisible();

			var cvc = new CalcViewController();

			var navController = new UINavigationController(cvc);

			Window.RootViewController = navController;

			return true;
		}
	}
}

