namespace Parsec.Extensions;

internal static class TypeExtensions
{
    public static IEnumerable<Type> GetBaseClassesAndInterfaces(this Type type)
    {
        if (type.BaseType == null)
        {
            throw new Exception($"Type {type.Name} is invalid");
        }

        return type.BaseType == typeof(object)
            ? type.GetInterfaces()
            : Enumerable
                .Repeat(type.BaseType, 1)
                .Concat(type.GetInterfaces())
                .Concat(type.BaseType.GetBaseClassesAndInterfaces())
                .Distinct();
    }
}
