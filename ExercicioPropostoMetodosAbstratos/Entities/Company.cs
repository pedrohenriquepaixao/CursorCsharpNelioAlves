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

        public Company(string Name, double AnualIncome, int numberEmployees) :base(Name,AnualIncome)
        {
            NumberEmployees = numberEmployees;
        }

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
