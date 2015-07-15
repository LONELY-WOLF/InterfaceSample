using InterfaceSample.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace InterfaceSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        NavigationHelper navigationHelper;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.

            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (appBarToggleButton.IsChecked == true)
            {
                appBarToggleButton.IsChecked = false;
                e.Handled = true;
            }
        }

        private void listBoxItemMenu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            appBarToggleButton.IsChecked = false;
            if (sender == listBoxItemNews)
            {
                mainPivot.SelectedIndex = 0;
            }
            else if (sender == listBoxItemMail)
            {
                mainPivot.SelectedIndex = 1;
            }
            else if (sender == listBoxItemFav)
            {
                mainPivot.SelectedIndex = 2;
            }
            else if (sender == listBoxItemSettings)
            {
                
            }
            else if (sender == listBoxItemAbout)
            {
                this.Frame.Navigate(typeof(About));
            }
        }

        private void AppBarButtonMore_Click(object sender, RoutedEventArgs e)
        {
            AppBarButton btn = sender as AppBarButton;
            MenuFlyout flt = btn.Resources["MenuFlyout"] as MenuFlyout;
            flt.ShowAt(mainPivot);
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            appBarToggleButton.IsChecked = false;
        }

        private async void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {

        }
        private async void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {

        }
    }
}
