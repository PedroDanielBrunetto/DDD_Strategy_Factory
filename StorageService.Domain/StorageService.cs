using StorageService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageService.Domain.Enums.Enums;

namespace StorageService.Domain
{
    public class StorageService : IStorageService
    {
        public int WhichService(enValueStorage choice)
        {
            int response = 0;

            if(choice > 0)
                response = (int)choice;

            return response;
        }
    }
}
