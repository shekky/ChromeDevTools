using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StartSampling)]
	[SupportedBy("Chrome")]
	public class StartSamplingCommand
	{
		/// <summary>
		/// Gets or sets Average sample interval in bytes. Poisson distribution is used for the intervals. The default value is 32768 bytes.
		/// </summary>
		public double SamplingInterval { get; set; }
	}
}
