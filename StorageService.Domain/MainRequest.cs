using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageService.Domain.Enums.Enums;

namespace StorageService.Domain
{
    public class MainRequest
    {
        public string NameBusiness { get; set; }
        public int QuantityLots { get; set; }
        public enValueStorage SelectedStorageService { get; set; }
        public enValueComplements SelectedComplementsService { get; set; }
    }
}
