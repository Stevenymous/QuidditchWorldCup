using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation de l'interface IDalManagerMatch
    /// </summary>
    internal class StubDalManagerMatch : IDalManagerMatch
    {
        /// <summary>
        /// Permet d'obtenir la liste des matches
        /// </summary>
        /// <returns>la liste des matches</returns>
        public IList<IMatch> ObtenirMatches()
        {
            //IDalManagerEquipe dalManagerEquipe = new StubDalManagerEquipe();
            //IList<IEquipe> equipes = dalManagerEquipe.ObtenirEquipes();
            //IDalManagerStade dalManagerStade = new StubDalManagerStade();
            //IList<IStade> stades = dalManagerStade.ObtenirStades();

            IList<IMatch> matches = new List<IMatch>();
            matches.Add(FabriqueMatch.CreerMatch(0, "04/03/2015", null, null, null, 
               null, null, 60, 160));
            matches.Add(FabriqueMatch.CreerMatch(0, "06/07/2015", null, null, null,
               null, null, 160, 170));
            //matches.Add(FabriqueMatch.CreerMatch(0, "04/03/2015", null, stades[0], null, 
            //   equipes[0], equipes[1], 60, 160));
            //matches.Add(FabriqueMatch.CreerMatch(0, "06/07/2015", null, stades[3], null,
            //   equipes[1], equipes[0], 160, 170));
            return matches;
        }
    }
}
