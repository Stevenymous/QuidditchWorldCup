using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayerBaseDeDonnees
{
    /// <summary>
    /// A pour responsabilité d'adapter les données provennant de la base de données pour d'autres couches (BusinessLayer) 
    /// </summary>
    internal class DataAdapterSql : IDataAdapter
    {
        #region Operations

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IMatch
        /// </summary>
        /// <param name="ligneMatch">La ligne d'un match en base de données</param>
        /// <returns>L'instance de IMatch</returns>
        public IMatch TransformRowInMatch(DataRow ligneMatch)
        {
            return FabriqueMatch.CreerMatch(ligneMatch["id"].ToString(), ligneMatch["dateMatch"].ToString(), 
                null, null, null, null, null, ligneMatch["scoreEquipeDomicile"].ToString(), 
                ligneMatch["scoreEquipeVisiteur"].ToString()); 
        }

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IArbitre
        /// </summary>
        /// <param name="ligneArbitre">La ligne d'un arbitre en base de données</param>
        /// <returns>L'instance de IArbitre</returns>
        public IArbitre TransformRowInArbitre(DataRow ligneArbitre)
        {
            return FabriqueArbitre.CreerArbitre(ligneArbitre["id"].ToString(), ligneArbitre["prenom"].ToString(), 
                ligneArbitre["nom"].ToString(), ligneArbitre["dateNaissance"].ToString(), 
                ligneArbitre["numeroAssuranceVie"].ToString());
        }

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IReservation
        /// </summary>
        /// <param name="ligneReservation">La ligne d'un reservation en base de données</param>
        /// <returns>L'instance de IReservation</returns>
        public IReservation TransformRowInReservation(DataRow ligneReservation)
        {
            return FabriqueReservation.CreerReservation(ligneReservation["id"].ToString(), ligneReservation["prix"].ToString(),
                ligneReservation["place"].ToString());
        }

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de ISpectateur
        /// </summary>
        /// <param name="ligneSpectateur">La ligne d'un spectateur en base de données</param>
        /// <returns>L'instance de ISpectateur</returns>
        public ISpectateur TransformRowInSpectateur(DataRow ligneSpectateur)
        {
            return FabriqueSpectateur.CreerSpectateur(ligneSpectateur["id"].ToString(), ligneSpectateur["prenom"].ToString(),
                ligneSpectateur["nom"].ToString(), ligneSpectateur["dateNaissance"].ToString(), ligneSpectateur["adresse"].ToString(),
                ligneSpectateur["email"].ToString(), null);
        }

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IJoueur
        /// </summary>
        /// <param name="ligneJoueur">La ligne d'un joueur en base de données</param>
        /// <returns>L'instance de IJoueur</returns>
        public IJoueur TransformRowInJoueur(DataRow ligneJoueur)
        {
            return FabriqueJoueur.CreerJoueur(ligneJoueur["id"].ToString(), ligneJoueur["prenom"].ToString(), 
                ligneJoueur["nom"].ToString(), ligneJoueur["dateNaissance"].ToString(), ligneJoueur["capitaine"].ToString(),
                ligneJoueur["poste"].ToString(), ligneJoueur["nombreSelection"].ToString());
        }

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IEquipe
        /// </summary>
        /// <param name="ligneEquipe">La ligne d'un equipe en base de données</param>
        /// <returns>L'instance de IEquipe</returns>
        public IEquipe TransformRowInEquipe(DataRow ligneEquipe)
        {
            return FabriqueEquipe.CreerEquipe(ligneEquipe["id"].ToString(), ligneEquipe["nom"].ToString(),
                ligneEquipe["pays"].ToString(), null);
        }

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de ICoupe
        /// </summary>
        /// <param name="ligneCoupe">La ligne d'un coupe en base de données</param>
        /// <returns>L'instance de ICoupe</returns>
        public ICoupe TransformRowInCoupe(DataRow ligneCoupe)
        {
            return FabriqueCoupe.CreerCoupe(ligneCoupe["id"].ToString(), ligneCoupe["dateCoupe"].ToString(), null);
        }

        /// <summary>
        /// Transforme une ligne d'une DataTable en instance de IStade
        /// </summary>
        /// <param name="ligneStade">La ligne d'un stade en base de données</param>
        /// <returns>L'instance de IStade</returns>
        public IStade TransformRowInStade(DataRow ligneStade)
        {
            return FabriqueStade.CreerStade(ligneStade["id"].ToString(), ligneStade["nom"].ToString(), 
                ligneStade["adresse"].ToString(), ligneStade["nombrePlace"].ToString(), ligneStade["commission"].ToString());
        }

        #endregion
    }
}
