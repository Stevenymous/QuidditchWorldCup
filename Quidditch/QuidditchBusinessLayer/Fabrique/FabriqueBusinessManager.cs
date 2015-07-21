using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Permet de construire une instance de BusinessManager afin de pouvoir l'adapter à nos besoins
    /// </summary>
    public static class FabriqueBusinessManager
    {
        #region Operations

        /// <summary>
        /// Construit une instance de IBusinessManager
        /// </summary>
        /// <param name="typeDal">Type de la Dal que l'on souhaite utiliser</param>
        /// <returns>Une implémentation de IBusinessManager</returns>
        public static IBusinessManager ConstruireBusinessManager(string typeDal)
        {
            return new BusinessManager(typeDal);
        }

        #endregion
    }
}
