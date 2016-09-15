﻿using System;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace $rootnamespace$
{
    sealed partial class App : Windows.UI.Xaml.Application
    {
        protected override void OnActivated(IActivatedEventArgs args)
        {
            if (args.Kind == ActivationKind.Protocol)
            {
                ProtocolActivatedEventArgs protocolArgs = (ProtocolActivatedEventArgs)args;
                Uri uri = protocolArgs.Uri;

                var callbackUri = "";  //TODO: add OAuth callback uri
				
                if (uri.ToString().StartsWith(callbackUri))
                {
					//necessary for custom uri scheme OAuth callbacks to function
                    Material.Framework.Platform.Current.Protocol(uri);
                }

                var frame = Window.Current.Content as Frame;
                if (frame == null)
                    frame = new Frame();

                frame.Navigate(typeof(MainPage), uri);
                Window.Current.Content = frame;
                Window.Current.Activate();
            }
        }
    }
}
