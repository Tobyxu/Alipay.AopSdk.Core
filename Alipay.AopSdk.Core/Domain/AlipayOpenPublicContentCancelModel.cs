using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicContentCancelModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicContentCancelModel : AopObject
	{
		/// <summary>
		///     message_id 是发布接口调用之后拿到的返回值，用来撤回已经发布的对应内容
		/// </summary>
		[JsonProperty("message_id")]
		public string MessageId { get; set; }
	}
}