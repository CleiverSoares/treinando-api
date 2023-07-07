
namespace src.Interfaces
{
    public interface IUpdate<in T, out A>
    {
        A Editar(int id, T obj);
        

    }
}