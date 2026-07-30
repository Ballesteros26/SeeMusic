using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	public sealed class CoreRegistry
	{
		public static CoreRegistry Instance { get; internal set; }

		[NotNull]
		internal IPackageRegistry PackageRegistry { get; private set; }

		[NotNull]
		internal IComponentRegistry ComponentRegistry { get; private set; }

		internal CoreRegistry()
		{
		}

		public CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		public void RegisterServiceComponent<TComponent>([NotNull] TComponent component) where TComponent : IServiceComponent
		{
		}

		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return default(TComponent);
		}

		internal void LockPackageRegistration()
		{
		}

		internal void LockComponentRegistration()
		{
		}
	}
}
