namespace Nova3diLab.Df2.Converters
{
    public interface IModelConvertable<T>
    {
        Model Convert(T item);
    }
}