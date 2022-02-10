using System.Collections.Generic;
namespace OopDesigns.LibraryManagementSystem
{
    // K is a class which describes id on the class T
    public interface IRepository<T, K>
    {
        List<T> GetAll();
        T Get(K id);
        T Update(T toUpdate);
        void Delete(K id);
        void Delete(T toDelete);
        T Create(T toCreate);
    }
}