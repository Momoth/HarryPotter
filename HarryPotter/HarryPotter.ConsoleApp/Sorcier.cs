using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.ConsoleApp
{
    public class Sorcier
    {
        public bool EstEnEntrainement { get; set; }

        public Sorcier()
        {
            EstEnEntrainement = true;
        }

        public void IncanterUnSort(string formule)
        {
            var formulesDisponibles = this.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            var formulesNames = formulesDisponibles.Select(m => m.Name).ToList();

            if (!string.IsNullOrEmpty(formule) && formulesDisponibles.Select(m => m.Name).Contains(formule))
            {
                var formuleChoisie = formulesDisponibles.Single(f => f.Name == formule);
                formuleChoisie.Invoke(this, null);
            }
            else
            {
                Console.WriteLine("La formule n'a aucun effet.");
            }
        }

        private void WindgardiumLeviosa()
        {
            Console.WriteLine("La cible vole !");
        }

        private void Accio()
        {
            Console.WriteLine("La cible est attiré à toi !");
        }

        private void Finito()
        {
            Console.WriteLine("La cible disparait. L'entrainement est terminé.");
            EstEnEntrainement = false;
        }
    }
}
