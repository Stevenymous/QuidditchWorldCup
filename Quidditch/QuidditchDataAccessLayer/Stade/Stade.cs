using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation d'un Stade
    /// </summary>
    internal class Stade : Entite, IStade
    {
        #region Fields

        /// <summary>
        /// Nom du Stade
        /// </summary>
        private string _nom;

        /// <summary>
        /// Adresse du stade
        /// </summary>
        private string _adresse;

        /// <summary>
        /// Nombre de place du stade
        /// </summary>
        private int _nombreDePlace;

        /// <summary>
        /// Commission perçu
        /// </summary>
        private float _commission;
        
        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture/écriture au nom du stade
        /// </summary>
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à l'adresse du stade
        /// </summary>
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture au nombre de place du stade
        /// </summary>
        public int NombreDePlace
        {
            get { return _nombreDePlace; }
            set { _nombreDePlace = value; }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture aà la commission perçu par places
        /// </summary>
        public float Commission
        {
            get { return _commission; }
            set { _commission = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Stade()
        { }

        /// <summary>
        /// Constructeur d'une instance de Stade avec son identifiant, son nom, son adresse et son nombre de places
        /// </summary>
        /// <param name="identifiant">L'identifiant du stade</param>
        /// <param name="nom">Nom du stade</param>
        /// <param name="adresse">Adresse du stade</param>
        /// <param name="nombreDePlace">Nom de place dans le stade</param>
        /// <param name="commission">Commission perçu</param>
        public Stade(int identifiant, string nom, string adresse, int nombreDePlace, float commission)
            : base(identifiant)
        {
            Nom = nom;
            Adresse = adresse;
            NombreDePlace = nombreDePlace;
            Commission = commission;
        }

        /// <summary>
        /// Constructeur par copie d'une Stade
        /// </summary>
        /// <param name="stadeToCopy">Stade à copier</param>
        public Stade(IStade stadeToCopy)
            : this(stadeToCopy.Identifiant, stadeToCopy.Nom, stadeToCopy.Adresse, stadeToCopy.NombreDePlace, stadeToCopy.Commission)
        {

        }

        #endregion
    }
}
