using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BengansBowling.Repositories
{
    public interface IRepo <T>
    {
        void Add(T value);

        void Add(List<T> value);

        void Update(T value);

        void Delete(T value);

        T Get(int id);
        List<T> GetList();
    }
}
