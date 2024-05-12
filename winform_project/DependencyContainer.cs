using Autofac;
using winform_project;

public static class DependencyContainer
{
    public static IContainer _container;

    public static void RegisterDependencies()
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<AppDbContext>().SingleInstance();

        _container = builder.Build();
    }

    public static T Resolve<T>()
    {
        return _container.Resolve<T>();
    }
}
