using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMetodosAbstratos.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpenditures { get; set; }


        public Individual()
        {
        }

        public Individual(string Name, double AnualIncome,double healthExpenditures) : base(Name,AnualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
