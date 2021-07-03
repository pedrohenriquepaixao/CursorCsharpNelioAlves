using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMetodosAbstratos.Entities
{
    class Company : Taxpayer
    {
        public int NumberEmployees { get; set; }

        public override double TaxesPaid()
        {
            if (NumberEmployees > 10)
            {
                return AnualIncome * 0.14;
            }

            return AnualIncome * 0.16;
        }
    }
}
