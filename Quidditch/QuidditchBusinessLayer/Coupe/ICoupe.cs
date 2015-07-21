﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Définition des caractéristiques d'une Coupe
    /// </summary>
    public interface ICoupe : IEntite
    {
        /// <summary>
        /// Date de la coupe
        /// </summary>
        DateTime DateDeLaCoupe
        {
            get;
            set;
        }

        /// <summary>
        /// Liste des matches de la coupe
        /// </summary>
        IList<IMatch> Matches
        {
            get;
            set;
        }
    }
}
