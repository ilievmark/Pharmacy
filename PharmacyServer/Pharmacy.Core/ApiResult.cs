namespace Pharmacy.Domain
{
    public class ApiResult<T>
    {
        public Status Status { get; init; }
        public T Result { get; init; }
    }
}
