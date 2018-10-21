using System;
using Autofac;
using Examples.Examples;

namespace Examples
{
	public class Program
	{
		static void Main(string[] args)
		{
			var container = ContainerConfig.Configure<ExampleCreateBox>();

			using (var scope = container.BeginLifetimeScope())
			{
				var example = scope.Resolve<IExample>();
				example.Run();
			}
		}
	}
}
