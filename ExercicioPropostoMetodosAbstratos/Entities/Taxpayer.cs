using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMetodosAbstratos.Entities
{
     abstract class Taxpayer
     {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();

       
     }
}
