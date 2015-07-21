using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// Défini les méthodes permettant de transformer des lignes de base de données en interface d'objets métier
    /// </summary>
    internal interface IDataAdapter
    {
        #region Operations

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IMatch
        /// </summary>
        /// <param name="ligneMatch">La ligne d'un match en base de données</param>
        /// <returns>L'instance de IMatch</returns>
        IMatch TransformRowInMatch(DataRow ligneMatch);

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IArbitre
        /// </summary>
        /// <param name="ligneArbitre">La ligne d'un arbitre en base de données</param>
        /// <returns>L'instance de IArbitre</returns>
        IArbitre TransformRowInArbitre(DataRow ligneArbitre);

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IReservation
        /// </summary>
        /// <param name="ligneReservation">La ligne d'un reservation en base de données</param>
        /// <returns>L'instance de IReservation</returns>
        IReservation TransformRowInReservation(DataRow ligneReservation);

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de ISpectateur
        /// </summary>
        /// <param name="ligneSpectateur">La ligne d'un spectateur en base de données</param>
        /// <returns>L'instance de ISpectateur</returns>
        ISpectateur TransformRowInSpectateur(DataRow ligneSpectateur);

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IJoueur
        /// </summary>
        /// <param name="ligneJoueur">La ligne d'un joueur en base de données</param>
        /// <returns>L'instance de IJoueur</returns>
        IJoueur TransformRowInJoueur(DataRow ligneJoueur);

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IEquipe
        /// </summary>
        /// <param name="ligneEquipe">La ligne d'un equipe en base de données</param>
        /// <returns>L'instance de IEquipe</returns>
        IEquipe TransformRowInEquipe(DataRow ligneEquipe);

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de ICoupe
        /// </summary>
        /// <param name="ligneCoupe">La ligne d'un coupe en base de données</param>
        /// <returns>L'instance de ICoupe</returns>
        ICoupe TransformRowInCoupe(DataRow ligneCoupe);

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IStade
        /// </summary>
        /// <param name="ligneStade">La ligne d'un stade en base de données</param>
        /// <returns>L'instance de IStade</returns>
        IStade TransformRowInStade(DataRow ligneStade);

        #endregion
    }
}
