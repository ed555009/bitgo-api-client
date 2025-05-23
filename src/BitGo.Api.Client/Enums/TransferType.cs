using System.ComponentModel;

namespace BitGo.Api.Client.Enums;

public enum TransferType
{
	[Description("轉出")]
	Send,

	[Description("轉入")]
	Receive
}
