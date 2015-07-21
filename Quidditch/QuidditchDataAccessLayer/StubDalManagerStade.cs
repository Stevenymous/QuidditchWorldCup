using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation de l'interface IDalManagerStade
    /// </summary>
    internal class StubDalManagerStade : IDalManagerStade
    {
        /// <summary>
        /// Permet d'obtenir la liste des stades
        /// </summary>
        /// <returns>La liste des stades</returns>
        public IList<IStade> ObtenirStades()
        {
            IList<IStade> stades = new List<IStade>();
            stades.Add(FabriqueStade.CreerStade(0, "Marcel Michelin", "Montferrand", 20000, 14.5f));
            stades.Add(FabriqueStade.CreerStade(0, "Jean Bouin", "Bobigny", 22000, 23.0f));
            stades.Add(FabriqueStade.CreerStade(0, "Ernest Wallon", "Toulouse", 31000, 11.0f));
            stades.Add(FabriqueStade.CreerStade(0, "Yves le Manoir", "Montpellier", 14000, 12.0f));
            return stades;
        }
    }
}
