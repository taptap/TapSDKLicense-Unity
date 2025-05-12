using TapSDK.License;
using TapSDK.License.Internal;
using TapSDK.Core;

namespace TapSDK.License.Standalone {
    public class TapLicenseStandalone : ITapLicenseBridge {
        public void CheckLicense()
        {
            TapLogger.Warn($"{nameof(CheckLicense)} NOT implemented.");
        }

        public void CheckLicenseForcibly()
        {
            TapLogger.Warn($"{nameof(CheckLicenseForcibly)} NOT implemented.");
        }

        public void PurchaseDLC(string sku) {
            TapLogger.Warn($"{nameof(PurchaseDLC)} NOT implemented.");
        }

        public void QueryDLC(string[] skus) {
            TapLogger.Warn($"{nameof(QueryDLC)} NOT implemented.");
        }

        public void RegisterDLCCallback(ITapDlcCallback callback)
        {
            TapLogger.Warn($"{nameof(RegisterDLCCallback)} NOT implemented.");
        }

        public void RegisterLicencesCallback(ITapLicenseCallback callback)
        {
            TapLogger.Warn($"{nameof(RegisterLicencesCallback)} NOT implemented.");

        }

        public void SetTestEnvironment(bool isTest){
             TapLogger.Warn($"{nameof(SetTestEnvironment)} NOT implemented.");
        }

       
    }
}
