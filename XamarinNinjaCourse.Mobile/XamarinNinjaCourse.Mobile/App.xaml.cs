// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.cs" company="Diego Arenas T.">
//  © All rights reserved
// </copyright>
// <summary>
//   App class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinNinjaCourse.Mobile
{
    using Xamarin.Forms;

    /// <summary>
    /// App
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Application" />
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        /// <summary>
        /// Application developers override this method to perform actions when the application starts.
        /// </summary>
        /// <remarks>
        /// To be added.
        /// </remarks>
        protected override void OnStart()
        {
        }

        /// <summary>
        /// Application developers override this method to perform actions when the application enters the sleeping state.
        /// </summary>
        /// <remarks>
        /// To be added.
        /// </remarks>
        protected override void OnSleep()
        {
        }

        /// <summary>
        /// Application developers override this method to perform actions when the application resumes from a sleeping state.
        /// </summary>
        /// <remarks>
        /// To be added.
        /// </remarks>
        protected override void OnResume()
        {
        }
    }
}
