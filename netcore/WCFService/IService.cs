using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace WCFService
{
	[ServiceContract]
	public interface IPingService
	{
		[OperationContract]
		string Ping(string msg);
	}

	public class SampleService : IPingService
	{
		public string Ping(string msg)
		{
			return string.Join(string.Empty, msg.Reverse());
		}
	}
}
