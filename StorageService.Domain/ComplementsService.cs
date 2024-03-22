using StorageService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StorageService.Domain.Enums.Enums;

namespace StorageService.Domain
{
    public class ComplementsService : IComplementsService
    {
        public int TotalServicesComplements(enValueComplements type)
        {
            int response = 0;

            if (type == enValueComplements.DESOVA_20 || type == enValueComplements.DESOVA_20)
                response = Desova(type);
            else
                response = Estufagem(type);

            return response;
        }

        private int Estufagem(enValueComplements weight)
        {
            int response = 0;

            if (weight == enValueComplements.ESTUFAGEM_20)
                response = 2500;
            else
                response = 4000;

            return response;
        }

        private int Desova(enValueComplements weight)
        {
            int response = 0;

            if (weight == enValueComplements.DESOVA_20)
                response = 2500;
            else
                response = 4000;

            return response;
        }
    }
}
