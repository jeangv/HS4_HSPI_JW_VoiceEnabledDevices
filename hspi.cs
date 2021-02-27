using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeSeer.PluginSdk;
using HomeSeer.Jui.Views;

namespace HSPI_JW_VoiceEnabledDevices
{
    public class HSPI : AbstractPlugin
    {
        public IHsController hs => HomeSeerSystem;
        public override string Id { get; } = "JW-VoiceEnabledDevices";
        public override string Name { get; } = "Manage Voice Devices";
        protected override string SettingsFileName { get; } = "Valid_Voice_Enabled_Devices.ini";
        public HSPI()
        {
        }
        protected override void Initialize()
        {
            Console.WriteLine("Initialize called, plug-in is being initialized...");
            Status = PluginStatus.Ok();
            Console.WriteLine("Plugin is initialized...");
            Console.WriteLine("-----------------------------------------");
        }
        protected override bool OnSettingChange(string pageId, AbstractView currentView, AbstractView changedView)
        {
            return true;
        }
        protected override void BeforeReturnStatus()
        {
            // When HomeSeer does a plugin status check it fires off this first. You should make sure all is well here and if not change the Status = PluginStatus.Ok() To Something Else
        }
    }
}
