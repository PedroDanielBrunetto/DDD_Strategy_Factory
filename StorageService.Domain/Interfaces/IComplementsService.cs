﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageService.Domain.Enums.Enums;

namespace StorageService.Domain.Interfaces
{
    public interface IComplementsService
    {
        int TotalServicesComplements(enValueComplements type);
    }
}