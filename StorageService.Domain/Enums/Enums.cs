using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageService.Domain.Enums
{
    public static class Enums
    {
        public enum enValueStorage
        {
            [Description("Valor do local X (Respectivo a 30 dias)")]
            X = 2500,
            [Description("Valor do local Y (Respectivo a 30 dias)")]
            Y = 5000,
            [Description("Valor do local Z (Respectivo a 30 dias)")]
            Z = 7500,
        }

        public enum enValueComplements
        {
            [Description("Valor do Serviço de Desova (CNTR 20)")]
            DESOVA_20 = 1,
            [Description("Valor do Serviço de Desova (CNTR 40)")]
            DESOVA_40 = 2,
            [Description("Valor do Serviço de Estufagem (CNTR 20)")]
            ESTUFAGEM_20 = 3,
            [Description("Valor do Serviço de Estufagem (CNTR 40)")]
            ESTUFAGEM_40 = 4,
        }
    }
}
