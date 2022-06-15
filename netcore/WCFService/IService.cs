using System;
using System.Linq;
using System.ServiceModel;

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
			return "Hello world, " + string.Join(string.Empty, msg.Reverse()) + "!";
		}
	}
}
