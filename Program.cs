using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSPI_JW_VoiceEnabledDevices
{
	internal static class Program
	{
		private static HSPI _plugin;
		public static void Main(string[] args)
		{
			Console.WriteLine("Connecting to server...");
			_plugin = new HSPI();
			_plugin.Connect(args);
		}
	}
}
