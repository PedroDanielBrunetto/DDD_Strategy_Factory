using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageService.Domain.Enums.Enums;

namespace StorageService.Domain.Interfaces
{
    public interface IStorageService
    {
        int WhichService(enValueStorage choice);
    }
}
