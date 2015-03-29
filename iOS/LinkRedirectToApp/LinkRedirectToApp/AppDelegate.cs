using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;
using System.Security.Cryptography;

namespace LinkRedirectToApp
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
		
        public override UIWindow Window
        {
            get;
            set;
        }

        public override void OnActivated(UIApplication application)
        {

//            NSHttpCookieStorage.SharedStorage.AcceptPolicy = NSHttpCookieAcceptPolicy.Always;
//
//            var cookieProperties = new NSMutableDictionary();
//
//            cookieProperties.SetValueForKey(new NSString("appInstalled"), NSHttpCookie.KeyName);
//            cookieProperties.SetValueForKey(new NSString("http://www.google.com/"), NSHttpCookie.KeyValue);
//            cookieProperties.SetValueForKey(new NSString("localhost"), NSHttpCookie.KeyDomain);
//            cookieProperties.SetValueForKey(new NSString(""), NSHttpCookie.KeyOriginUrl);
//            cookieProperties.SetValueForKey(new NSString("/"), NSHttpCookie.KeyPath);
//            cookieProperties.SetValueForKey(new NSString("0"), NSHttpCookie.KeyVersion);
//
//            cookieProperties.SetValueForKey(NSDate.FromTimeIntervalSinceNow(2629743), NSHttpCookie.KeyExpires);
//
//            var cookie = new NSHttpCookie(cookieProperties);
//            NSHttpCookieStorage.SharedStorage.SetCookie(cookie);
//
//            UIApplication.SharedApplication.OpenUrl(NSUrl.FromString("http://localhost:3000/"));

        }

        public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
        {
            new UIAlertView("Inter-app communication", "Query: " + url.Query, null, "OK", null).Show();
            return true;
        }
		
        // This method is invoked when the application is about to move from active to inactive state.
        // OpenGL applications should use this method to pause.
        public override void OnResignActivation(UIApplication application)
        {
        }
		
        // This method should be used to release shared resources and it should store the application state.
        // If your application supports background exection this method is called instead of WillTerminate
        // when the user quits.
        public override void DidEnterBackground(UIApplication application)
        {
        }
		
        // This method is called as part of the transiton from background to active state.
        public override void WillEnterForeground(UIApplication application)
        {
        }
		
        // This method is called when the application is about to terminate. Save data, if needed.
        public override void WillTerminate(UIApplication application)
        {
        }
       
    }
}

