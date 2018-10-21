using Autofac;
using Examples.Examples;
using SvgSharp;
using SvgSharp.Interfaces;

namespace Examples
{
	public static class ContainerConfig
	{
		public static IContainer Configure<T>() where T : IExample
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<T>().As<IExample>();
			builder.RegisterType<SvgDocument>().As<ISvgDocument>();

			return builder.Build();
		}
	}
}