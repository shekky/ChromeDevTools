using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Enables network tracking, network events will now be delivered to the client.
	/// </summary>
	[Command(ProtocolName.Network.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand
	{
		/// <summary>
		/// Gets or sets Buffer size in bytes to use when preserving network payloads (XHRs, etc).
		/// </summary>
		public long MaxTotalBufferSize { get; set; }
		/// <summary>
		/// Gets or sets Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).
		/// </summary>
		public long MaxResourceBufferSize { get; set; }
	}
}
