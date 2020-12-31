// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Application.cs" company="Diego Arenas T.">
//  © All rights reserved
// </copyright>
// <summary>
//  Application
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinNinjaCourse.Mobile.iOS
{
    using UIKit;

    /// <summary>
    /// Application
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Defines the entry point of the application. This is the main entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
