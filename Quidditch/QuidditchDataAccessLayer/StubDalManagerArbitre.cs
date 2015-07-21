using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation de l'interface IDalManagerArbitre
    /// </summary>
    internal class StubDalManagerArbitre : IDalManagerArbitre
    {
        /// <summary>
        /// Permet d'obtenir la liste des arbitres
        /// </summary>
        /// <returns>la liste des arbitres</returns>
        public IList<IArbitre> ObtenirArbitres()
        {
            IList<IArbitre> arbitres = new List<IArbitre>();
            arbitres.Add(FabriqueArbitre.CreerArbitre(0, "Jérome", "Garces", "28/04/1971", 1710464));
            arbitres.Add(FabriqueArbitre.CreerArbitre(0, "Mike", "Owens", "04/11/1964", 1641107));
            return arbitres;
        }
    }
}
