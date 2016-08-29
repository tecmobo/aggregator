#if __MOBILE__
using System.Threading.Tasks;
using Material.Infrastructure;
using Material.Infrastructure.Credentials;
using Material.Adapters;
using Material.Framework;
using Material.View.BluetoothAuthorization;

namespace Material
{
    public class BluetoothApp<TResourceProvider>
        where TResourceProvider : BluetoothResourceProvider, new()
    {
        /// <summary>
        /// Allows user to select bluetooth device
        /// </summary>
        /// <returns>Bluetooth credentials</returns>
        public Task<BluetoothCredentials> GetBluetoothCredentialsAsync()
        {
            var authenticationUI = new BluetoothAuthorizerUI(
                new BluetoothAdapter(Platform.Current.BluetoothAdapter));

            return authenticationUI.GetDeviceUuid();
        }
    }
}
#endif
