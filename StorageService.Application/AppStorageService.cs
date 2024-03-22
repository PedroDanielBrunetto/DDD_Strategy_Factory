using StorageService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageService.Domain.Enums.Enums;

namespace StorageService.Application
{
    public class AppStorageService
    {
        private readonly StorageServices _storageService;
        public AppStorageService(StorageServices storageServices)
        {
            _storageService = storageServices;
        }

        public int TotalService(int quantityLots, enValueStorage selectedStorageService, enValueComplements selectedComplementsService)
        {
            return _storageService.TotalService(quantityLots, selectedStorageService, selectedComplementsService);
        }

    }
}
