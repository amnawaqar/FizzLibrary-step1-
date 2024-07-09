using FizzLibrary.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibrary.Shared.Interface
{
    public interface IUserValue
    {
        UserValueDto Save(UserValueDto userValueDto);
    }
}
