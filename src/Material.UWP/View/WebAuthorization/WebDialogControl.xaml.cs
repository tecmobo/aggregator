﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Material.View.WebAuthorization
{
    public sealed partial class WebDialogControl : UserControl
    {
        private readonly Window _rootWindow;
        private readonly Action _cancelledAction;

        public WebView WebView => RootWebView;

        public WebDialogControl(
            Window rootWindow, 
            Action cancelledAction)
        {
            if (rootWindow == null) throw new ArgumentNullException(nameof(rootWindow));

            this.InitializeComponent();

            _rootWindow = rootWindow;
            _cancelledAction = cancelledAction;
        }

        public void Show(
            Uri pageUrl, 
            Func<Uri, WebDialogControl, bool> pageStartedHandler)
        {
            if (pageUrl == null) throw new ArgumentNullException(nameof(pageUrl));
            if (pageStartedHandler == null) throw new ArgumentNullException(nameof(pageStartedHandler));

            WebViewPopup.IsOpen = true;

            //TODO: convert to dependency parameters
            WebViewProgressRing.Visibility = Visibility.Visible;
            WebViewProgressRing.IsActive = true;

            RootWebView.NavigationStarting += (sender, args) =>
            {
                pageStartedHandler(args.Uri, this);
            };
            RootWebView.Navigate(pageUrl);
        }

        public void Hide()
        {
            WebViewPopup.IsOpen = false;
        }

        private void CancelButton_OnTapped(
            object sender, 
            TappedRoutedEventArgs e)
        {
            Hide();
            _cancelledAction?.Invoke();
        }

        private void RootWebView_OnNavigationCompleted(
            WebView sender, 
            WebViewNavigationCompletedEventArgs args)
        {
            //TODO: convert to dependency parameters
            if (RootWebView.Visibility == Visibility.Collapsed)
            {
                RootWebView.Visibility = Visibility.Visible;
                CloseButton.Visibility = Visibility.Visible;
                WebViewProgressRing.Visibility = Visibility.Collapsed;
                WebViewProgressRing.IsActive = false;
            }
        }

        private void OnLayoutUpdated(object sender, object e)
        {
            if (WebViewGrid.ActualWidth == 0 &&
                WebViewGrid.ActualHeight == 0)
            {
                return;
            }

            //TODO: convert to dependency parameters
            //Close button overlap of the webview is half of its width
            var closeButtonOverlap = CloseButton.ActualWidth / 2 + 1;

            if (CloseButton.Margin.Right != closeButtonOverlap ||
                CloseButton.Margin.Bottom != closeButtonOverlap)
            {
                CloseButton.Margin = new Thickness(
                0,
                0,
                -1 * closeButtonOverlap,
                -1 * closeButtonOverlap);
            }

            //TODO: convert to dependency parameters
            //The popup consumes a percentage of the total area of the apps window
            var newWindowHeight = 0.95 * _rootWindow.Bounds.Height;
            var newWindowWidth = 0.75 * _rootWindow.Bounds.Width;

            if (WebViewGrid.Height != newWindowHeight ||
                WebViewGrid.Width != newWindowWidth)
            {
                WebViewGrid.Height = newWindowHeight;
                WebViewGrid.Width = newWindowWidth;
            }

            //TODO: convert to dependency parameters
            //The popup window is in the center of the apps window
            var newHorizontalOffset =
                (_rootWindow.Bounds.Width - WebViewGrid.ActualWidth) / 2;
            var newVerticalOffset =
                (_rootWindow.Bounds.Height - WebViewGrid.ActualHeight) / 2;

            if (WebViewPopup.HorizontalOffset != newHorizontalOffset ||
                WebViewPopup.VerticalOffset != newVerticalOffset)
            {
                WebViewPopup.HorizontalOffset = newHorizontalOffset;
                WebViewPopup.VerticalOffset = newVerticalOffset;
            }
        }
    }
}
