using StorageService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageService.Domain.Enums.Enums;

namespace StorageService.Domain
{
    public class CalculateService : ICalculateService
    {
        private readonly MainRequest _mainRequest;
        private readonly IStorageService _storageService;
        private readonly IComplementsService _complementsService;

        public CalculateService(MainRequest mainRequest, IStorageService storageService, IComplementsService complementsService)
        {
            _mainRequest = mainRequest;
            _storageService = storageService;
            _complementsService = complementsService;
        }

        public int TotalService(int quantityLots, enValueStorage selectedStorageService, enValueComplements selectedComplementsService)
        {
            int response = 0;

            int StorageValue = _storageService.WhichService(selectedStorageService);

            response += (quantityLots * StorageValue);

            if (selectedComplementsService != null)
                response += _complementsService.TotalServicesComplements(selectedComplementsService);

            return response;
        }
    }
}
