using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome")]
	public class BreakLocation
	{
		/// <summary>
		/// Gets or sets Script identifier as reported in the <code>Debugger.scriptParsed</code>.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Line number in the script (0-based).
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Column number in the script (0-based).
		/// </summary>
		public long ColumnNumber { get; set; }
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public string Type { get; set; }
	}
}
