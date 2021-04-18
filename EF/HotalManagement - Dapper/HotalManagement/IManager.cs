using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalManagement
{
    interface IManager<T>
    {
        bool Add(T item);
        bool Delete(long id);
        List<T> GetAll();
        List<T> GetOccupied();
        List<T> GetReserved();
        List<T> ReservFilter(string name);
        T GetOne(long id);
        bool update(T item);
        bool AdminLogin(String username, String password);
        bool KitchenLogin(String username, String password);
    }
}
