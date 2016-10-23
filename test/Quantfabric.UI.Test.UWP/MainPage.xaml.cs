﻿using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Material;
using Material.Contracts;
using Material.Enums;
using Material.Framework;
using Material.Infrastructure.Credentials;
using Material.Infrastructure.OAuth;
using Material.Infrastructure.ProtectedResources;
using Material.Infrastructure.Requests;
using Material.Infrastructure.Responses;
using Quantfabric.Test.Helpers;
using Quantfabric.UI.Test.UWP.Annotations;

namespace Quantfabric.UI.Test.UWP
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _result;

        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public TestViewModel()
        {
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public sealed partial class MainPage : Page
    {
        private AuthenticationInterfaceEnum _browserType =
            AuthenticationInterfaceEnum.Embedded;
        private CallbackTypeEnum _callbackType =
            CallbackTypeEnum.Localhost;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void OnFacebookEmailClick(object sender, RoutedEventArgs e)
        {

            OAuth2Credentials credentials = await new OAuth2App<Facebook>(
                    "YOUR CLIENT ID",
                    "HTTP://YOURCALLBACKURI")
                .AddScope<FacebookUser>()
                .GetCredentialsAsync()
                .ConfigureAwait(false);

            FacebookUserResponse user = await new OAuthRequester(credentials)
                .MakeOAuthRequestAsync<FacebookUser, FacebookUserResponse>()
                .ConfigureAwait(false);

            string email = user.Email;
        }

        private async void OnGoogleEmailClick(object sender, RoutedEventArgs e)
        {
            OAuth2Credentials credentials = await new OAuth2App<Google>(
                    "YOUR CLIENT ID",
                    "HTTP://YOURCALLBACKURI")
                .AddScope<GoogleProfile>()
                .GetCredentialsAsync()
                .ConfigureAwait(false);

            GoogleProfileResponse profile = await new OAuthRequester(credentials)
                .MakeOAuthRequestAsync<GoogleProfile, GoogleProfileResponse>()
                .ConfigureAwait(false);

            string email = profile.Emails.First().Value;
        }

        private async void OnFacebookClick(object sender, RoutedEventArgs e)
        {
            var settings = new AppCredentialRepository(_callbackType);
            var clientId = settings.GetClientId<Facebook>();
            var clientSecret = settings.GetClientSecret<Facebook>();
            var redirectUri = settings.GetRedirectUri<Facebook>();

            var token = await new OAuth2App<Facebook>(
                        clientId,
                        redirectUri,
                        browserType: _browserType)
                    .AddScope<FacebookEvent>()
                    .GetCredentialsAsync()
                    .ConfigureAwait(false);

            WriteToTextbox($"AccessToken:{token.AccessToken}");
        }

        private async void OnTwitterClick(object sender, RoutedEventArgs e)
        {
            var settings = new AppCredentialRepository(_callbackType);
            var consumerKey = settings.GetConsumerKey<Twitter>();
            var consumerSecret = settings.GetConsumerSecret<Twitter>();
            var redirectUri = settings.GetRedirectUri<Twitter>();

            var token = await new OAuth1App<Twitter>(
                        consumerKey,
                        consumerSecret,
                        redirectUri,
                        browserType: _browserType)
                    .GetCredentialsAsync()
                    .ConfigureAwait(false);

            WriteToTextbox($"OAuthToken:{token.OAuthToken}, OAuthSecret:{token.OAuthSecret}");
        }

        private async void OnGoogleClick(object sender, RoutedEventArgs e)
        {
            var settings = new AppCredentialRepository(_callbackType);
            var clientId = settings.GetClientId<Google>();
            var clientSecret = settings.GetClientSecret<Google>();
            var redirectUri = settings.GetRedirectUri<Google>();

            var token = await new OAuth2App<Google>(
                        clientId,
                        redirectUri,
                        browserType: _browserType)
                    .AddScope<GoogleGmailMetadata>()
                    .AddScope<GoogleGmail>()
                    .GetCredentialsAsync()
                    .ConfigureAwait(false);

            WriteToTextbox($"AccessToken:{token.AccessToken}");
        }

        private async void OnFitbitClick(object sender, RoutedEventArgs e)
        {
            var settings = new AppCredentialRepository(_callbackType);
            var clientId = settings.GetClientId<Fitbit>();
            var clientSecret = settings.GetClientSecret<Fitbit>();
            var redirectUri = settings.GetRedirectUri<Fitbit>();

            var token = await new OAuth2App<Fitbit>(
                        clientId,
                        redirectUri,
                        browserType: _browserType)
                    .AddScope<FitbitIntradaySteps>()
                    .AddScope<FitbitIntradayStepsBulk>()
                    .GetCredentialsAsync()
                    .ConfigureAwait(false);

            WriteToTextbox($"AccessToken:{token.AccessToken}");
        }

        private async void OnPinterestClick(object sender, RoutedEventArgs e)
        {
            var settings = new AppCredentialRepository(_callbackType);
            var clientId = settings.GetClientId<Pinterest>();
            var clientSecret = settings.GetClientSecret<Pinterest>();
            var redirectUri = settings.GetRedirectUri<Pinterest>();

            var token = await new OAuth2App<Pinterest>(
                        clientId,
                        redirectUri,
                        browserType: _browserType)
                    .AddScope<PinterestLikes>()
                    .GetCredentialsAsync(clientSecret)
                    .ConfigureAwait(false);

            WriteToTextbox($"AccessToken:{token.AccessToken}");
        }

        private async void OnRunkeeperClick(object sender, RoutedEventArgs e)
        {
            var settings = new AppCredentialRepository(_callbackType);
            var clientId = settings.GetClientId<Runkeeper>();
            var clientSecret = settings.GetClientSecret<Runkeeper>();
            var redirectUri = settings.GetRedirectUri<Runkeeper>();

            var token = await new OAuth2App<Runkeeper>(
                        clientId,
                        redirectUri,
                        browserType: _browserType)
                    .AddScope<RunkeeperFitnessActivity>()
                    .GetCredentialsAsync(clientSecret)
                    .ConfigureAwait(false);

            WriteToTextbox($"AccessToken:{token.AccessToken}");
        }

        private void WriteToTextbox(string text)
        {
            Platform.Current.RunOnMainThread(() =>
            {
                ((TestViewModel) ((MainPage) Platform.Current.Context.Content).DataContext).Result = text;
            });
        }

        private void BrowserTypeToggled(object sender, RoutedEventArgs e)
        {
            _browserType = authTypeToggleSwitch.IsOn
                ? AuthenticationInterfaceEnum.Dedicated
                : AuthenticationInterfaceEnum.Embedded;
            _callbackType = authTypeToggleSwitch.IsOn
                ? CallbackTypeEnum.Protocol 
                : CallbackTypeEnum.Localhost;
        }
    }
}
