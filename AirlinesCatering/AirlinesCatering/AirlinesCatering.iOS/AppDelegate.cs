﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using SqliteApp.Standard;
using UIKit;

namespace AirlinesCatering.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
        
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"..","Library",
                "AirlineCateringDb.db");

            var _context = new AirlineContext(dbPath);

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App(_context));

            return base.FinishedLaunching(app, options);
        }
    }
}
