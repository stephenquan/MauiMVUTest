namespace AppFramework.Mvvm;

//[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public class ObservablePropertyAttribute : Attribute
{
}
