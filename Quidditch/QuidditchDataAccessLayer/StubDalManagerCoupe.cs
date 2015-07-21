using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation de l'interface IDalManagerCoupe
    /// </summary>
    internal class StubDalManagerCoupe : IDalManagerCoupe
    {
        #region Operations

        /// <summary>
        /// Permet d'obtenir la liste des coupes
        /// </summary>
        /// <returns>la liste des coupes</returns>
        public IList<ICoupe> ObtenirCoupes()
        {
            IList<ICoupe> coupes = new List<ICoupe>();
            coupes.Add(FabriqueCoupe.CreerCoupe(0, "04/07/2015", null));
            return coupes;
        }

        #endregion
    }
}
