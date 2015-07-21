﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Implémentation de l'équipe dans la QuidditchWebServices
    /// </summary>
    [DataContract]
    public class Equipe : Entite, IEquipe
    {
        #region Fields

        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        private string _nom;

        /// <summary>
        /// Liste des joueurs de l'équipe
        /// </summary>
        private IList<IJoueur> _joueurs;

        /// <summary>
        /// Pays de l'équipe
        /// </summary>
        private string pays;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture/écriture au nom de l'équipe
        /// </summary>
        [DataMember]
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à la liste des joueurs de l'équipe 
        /// </summary>
        [DataMember]
        public IList<IJoueur> Joueurs
        {
            get 
            {
                return _joueurs; 
            }
            set { _joueurs = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture / écriture au pays
        /// </summary>
        [DataMember]
        public string Pays
        {
            get { return pays; }
            set { pays = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Equipe()
        { 
        
        }

        /// <summary>
        /// Constructeur d'une équipe acceptant comme arguments l'identifiant de l'équipe, son nom, le nom du pays et ses joueurs
        /// </summary>
        /// <param name="identifiant">Identifiant de l'équipe</param>
        /// <param name="nom">Nom de l'équipe</param>
        /// <param name="pays">Pays de l'équipe</param>
        /// <param name="joueurs">Joueurs de l'équipe</param>
        public Equipe(int identifiant, string nom, string pays, IList<IJoueur> joueurs)
            : base(identifiant)
        {
            Nom = nom;
            Pays = pays;
            Joueurs = joueurs;
        }

        /// <summary>
        /// Constructeur par copie d'une Equipe
        /// </summary>
        /// <param name="equipeToCopy">Instance de l'équipe à copier</param>
        public Equipe(IEquipe equipeToCopy)
            :this(equipeToCopy.Identifiant, equipeToCopy.Nom, equipeToCopy.Pays ,equipeToCopy.Joueurs)
        {
        
        }

        #endregion
    }
}