using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation de l'interface IDalManagerEquipe
    /// </summary>
    internal class StubDalManagerEquipe : IDalManagerEquipe
    {
        /// <summary>
        /// Permet d'obtenir la liste des équipes présentes
        /// </summary>
        /// <returns>La liste des équipes</returns>
        public IList<IEquipe> ObtenirEquipes()
        {
            IDalManagerJoueur dalManagerJoueur = new StubDalManagerJoueur();

            List<IEquipe> equipes = new List<IEquipe>();
            equipes.Add(FabriqueEquipe.CreerEquipe(0, "JeanBonBeur", "Moldavie", null));
            equipes.Add(FabriqueEquipe.CreerEquipe(1, "CroustiBats", "Malawi", null));

            return equipes;
        }
    }
}
