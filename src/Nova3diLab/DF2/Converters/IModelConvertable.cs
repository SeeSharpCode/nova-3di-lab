namespace Nova3diLab.DF2.Converters
{
    public interface IModelConvertable<T>
    {
        Model Convert(T item);
    }
}