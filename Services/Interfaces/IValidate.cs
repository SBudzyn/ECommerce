namespace ECommerce.Services.Interfaces
{
    public interface IValidate<T>
    {
        T? Validate(T value);
    }
}
