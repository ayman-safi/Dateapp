using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.api.Models;

namespace DatingApp.api.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T Entity) where T: class;
         void Delete<T>(T Entity) where T :class;
         //asynch method 
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int Id);

    }
}