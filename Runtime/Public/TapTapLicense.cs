using TapSDK.License.Internal;
using TapSDK.Core.Internal.Utils;

namespace TapSDK.License {
    public class TapTapLicense {

        public static readonly string Version = "4.5.5";
        
        static readonly ITapLicenseBridge license;

        static TapTapLicense() {
            license = BridgeUtils.CreateBridgeImplementation(typeof(ITapLicenseBridge), "TapSDK.License")
                as ITapLicenseBridge;
        }

        public static void RegisterLicenseCallBack(ITapLicenseCallback callback) {
            license.RegisterLicencesCallback(callback);
        }

        public static void RegisterDLCCallback(ITapDlcCallback callback) {
            license.RegisterDLCCallback(callback);
        }


        public static void CheckLicense(bool force = false) {
            if(force){
                license.CheckLicenseForcibly();
            }else{
                license.CheckLicense();
            }
        }

        

        public static void QueryDLC(string[] dlcList) {
            license.QueryDLC(dlcList);
        }

        public static void PurchaseDLC(string dlc) {
            license.PurchaseDLC(dlc);
        }

        public static void SetTestEnvironment(bool isTest){
            license.SetTestEnvironment(isTest);
        }

    
    }
}
