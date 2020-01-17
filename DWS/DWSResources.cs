using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWS
{
    public static class DwsResources
    {
        public static string[] Disabletaskslist =
            {
                @"Microsoft\Windows\AppID\SmartScreenSpecific",
                @"Microsoft\Windows\Application Experience\AitAgent",
                @"Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser",
                @"Microsoft\Windows\Application Experience\ProgramDataUpdater",
                @"Microsoft\Windows\Application Experience\StartupAppTask",
                @"Microsoft\Windows\Autochk\Proxy",
                @"Microsoft\Windows\CloudExperienceHost\CreateObjectTask",
                @"Microsoft\Windows\Customer Experience Improvement Program\BthSQM",
                @"Microsoft\Windows\Customer Experience Improvement Program\Consolidator",
                @"Microsoft\Windows\Customer Experience Improvement Program\KernelCeipTask",
                @"Microsoft\Windows\Customer Experience Improvement Program\Uploader",
                @"Microsoft\Windows\Customer Experience Improvement Program\UsbCeip",
                @"Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector",
                @"Microsoft\Windows\DiskFootprint\Diagnostics",
                @"Microsoft\Windows\FileHistory\File History (maintenance mode)",
                @"Microsoft\Windows\Maintenance\WinSAT",
                @"Microsoft\Windows\Media Center\ActivateWindowsSearch",
                @"Microsoft\Windows\Media Center\ConfigureInternetTimeService",
                @"Microsoft\Windows\Media Center\DispatchRecoveryTasks",
                @"Microsoft\Windows\Media Center\ehDRMInit",
                @"Microsoft\Windows\Media Center\InstallPlayReady",
                @"Microsoft\Windows\Media Center\mcupdate",
                @"Microsoft\Windows\Media Center\MediaCenterRecoveryTask",
                @"Microsoft\Windows\Media Center\ObjectStoreRecoveryTask",
                @"Microsoft\Windows\Media Center\OCURActivate",
                @"Microsoft\Windows\Media Center\OCURDiscovery",
                @"Microsoft\Windows\Media Center\PBDADiscovery",
                @"Microsoft\Windows\Media Center\PBDADiscoveryW1",
                @"Microsoft\Windows\Media Center\PBDADiscoveryW2",
                @"Microsoft\Windows\Media Center\PvrRecoveryTask",
                @"Microsoft\Windows\Media Center\PvrScheduleTask",
                @"Microsoft\Windows\Media Center\RegisterSearch",
                @"Microsoft\Windows\Media Center\ReindexSearchRoot",
                @"Microsoft\Windows\Media Center\SqlLiteRecoveryTask",
                @"Microsoft\Windows\Media Center\UpdateRecordPath",
                @"Microsoft\Windows\PI\Sqm-Tasks",
                @"Microsoft\Windows\Power Efficiency Diagnostics\AnalyzeSystem",
                @"Microsoft\Windows\Shell\FamilySafetyMonitor",
                @"Microsoft\Windows\Shell\FamilySafetyRefresh",
                @"Microsoft\Windows\Shell\FamilySafetyUpload",
                @"Microsoft\Windows\Windows Error Reporting\QueueReporting"
            };
        public static string[] Regkeyvalandother =
        {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{21157C1F-2651-4CC1-90CA-1F28B02263F6}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{2EEF81BE-33FA-4800-9670-1CD474972C3F}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{7D7E8402-7C54-4821-A34E-AEEFD62DED93}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{992AFA70-6F47-4148-B3E9-3003349C1548}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{9D9E0118-1807-4F2E-96E4-2CE57142E196}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{A8804298-2D5F-42E3-9531-9C8C39EB29CE}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{B19F89AF-E3EB-444B-8DEA-202575A71599}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{C1D23ACC-752B-43E5-8448-8D0E519CD6D6}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{D89823BA-7180-4B81-B50C-7E471E6121A3}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{E5323777-F976-4f5b-9B55-B94699C46E44}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{E6AD100E-5F4E-44CD-BE0F-2265D88D14F5}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{E83AF229-8640-4D18-A213-E22675EBB2C3}",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\LooselyCoupled"
        };

        public static List<string> ServicesList = new List<string>(new[]
        {
            "DcpSvc", // Data Collection and Publishing Service
            "dmwappushservice", // WAP Push Message Routing Service
            "lfsvc", // Geolocation Service
            "MapsBroker", // Downloaded Maps Manager
            "WbioSrvc", // Windows Biometric Service
            "WMPNetworkSvc", // Windows Media Player Network Sharing Service
            "XblAuthManager", // Xbox Live Auth Manager
            "XblGameSave", // Xbox Live Game Save Service
            "XboxNetApiSvc", // Xbox Live Networking Service
            "OneSyncSvc", // Sync Host Service
            "AeLookupSvc", // Application Experience Service
            "UPNPHOST", // Universal Plug & Play Host
            "ERSVC", // Error Reporting Service
            "WERSVC", // Windows Error Reporting Service
            "SSDPSRV", // SSDP Discovery Service
        });
    }
}
