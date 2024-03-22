using StorageService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageService.Domain.Enums.Enums;

namespace StorageService.Service
{
    public class StorageServices
    {
        private readonly ICalculateService _calculateService;

        public StorageServices(ICalculateService calculateService)
        {
            _calculateService = calculateService;
        }

        public int TotalService(int quantityLots, enValueStorage selectedStorageService, enValueComplements selectedComplementsService)
        {
            return _calculateService.TotalService(quantityLots, selectedStorageService, selectedComplementsService);
        }
    }
}
