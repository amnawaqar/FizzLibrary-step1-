using FizzLibrary.Server.Model;
using FizzLibrary.Shared.Interface;

namespace FizzLibrary.Shared.Service
{
    public class UserValueService : IUserValue
    {
        public UserValueDto Save(UserValueDto userValueDto)
        {// all the DB logic for saving data will be done when requirements will be cleared
            return userValueDto;
        }
    }
}
