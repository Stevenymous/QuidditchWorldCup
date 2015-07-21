using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Objets de cette classe vont être sérialisés pour retrouver les informations sur la dimension et la position des fenêtres pour un utilisateur
    /// </summary>
    [Serializable]	
    internal class DimensionAndPosition : ISerializable
    {
        #region Fields

        /// <summary>
        /// Hauteur de la fenêtre à enregister
        /// </summary>
        private double _heightWindow;

        /// <summary>
        /// Largeur de la fenêtre à persister
        /// </summary>
        private double _widthWindow;

        /// <summary>
        /// Position de la fenêtre par rapport au haut de l'écran
        /// </summary>
        private double _positionTopWindow;

        /// <summary>
        /// Position de la fenêtre par rapport à la gauche de l'écran
        /// </summary>
        private double _positionLeftWindow;

        /// <summary>
        /// Nom de la fenêtre dont les dimensions et la position sont sauvegardées
        /// </summary>
        private string _windowName;

        #endregion

        #region Properties

        /// <summary>
        /// Propriété d'accès en lecture/écriture à la hauteur de la fenêtre
        /// </summary>
        public double HeightWindow
        {
            get
            {
                return _heightWindow;
            }
            set
            {
                _heightWindow = value;
            }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à la largeur de la fenêtre
        /// </summary>
        public double WidthWindow
        {
            get
            {
                return _widthWindow;
            }
            set
            {
                _widthWindow = value;
            }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture à la position par rapport au haut de l'écran
        /// </summary>
        public double TopWindow
        {
            get
            {
                return _positionTopWindow;
            }
            set
            {
                _positionTopWindow = value;
            }
        }

        /// <summary>
        /// Porpriété d'accès en lecture/écriture à la position par rapport à la gauche de l'écran
        /// </summary>
        public double LeftWindow
        {
            get
            {
                return _positionLeftWindow;
            }
            set
            {
                _positionLeftWindow = value;
            }
        }

        /// <summary>
        /// Propriété d'accès en lecture/écriture sur le nom de la fenêtre
        /// </summary>
        public string WindowName
        {
            get
            {
                return _windowName;
            }
            set
            {
                _windowName = value;
            }
        }
		 
	    #endregion

        #region Constructors

        /// <summary>
        /// Constructeur pour la déserialisation
        /// </summary>
        /// <param name="info">Instance de SerializationInfo</param>
        /// <param name="ctxt">instance de StreamingContext</param>
        public DimensionAndPosition(SerializationInfo info, StreamingContext ctxt)
        {
            WindowName = (string) info.GetValue("windowName", typeof(string));
            HeightWindow = (double) info.GetValue("heightWindow", typeof(double));
            WidthWindow = (double) info.GetValue("widthWindow", typeof(double));
            TopWindow = (double) info.GetValue("topWindow", typeof(double));
            LeftWindow = (double)  info.GetValue("leftwindow", typeof(double));
        }

        /// <summary>
        /// Constructeur d'un objet DimensionAndPosition
        /// </summary>
        /// <param name="heightWindow">Hauteur de la fenêtre</param>
        /// <param name="widthWindow">Largeur de la fenêtre</param>
        /// <param name="topWindow">Position par rapport au haut de l'écran</param>
        /// <param name="leftWindow">Position par rapport à la gauche de l'écran</param>
        /// <param name="windowName">Nom de la fenêtre</param>
        public DimensionAndPosition(double heightWindow, double widthWindow, double topWindow, double leftWindow, string windowName)
        {
            HeightWindow = heightWindow;
            WidthWindow = widthWindow;
            TopWindow = topWindow;
            LeftWindow = leftWindow;
            WindowName = windowName;
        }

        #endregion

        #region Operations

        /// <summary>
        /// Implémentation de l'interface ISerializable permetant de définir les données à sérialiser 
        /// </summary>
        /// <param name="info">Ensemble des données pour la sérialisation</param>
        /// <param name="context">La destination de la sérialisation</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("windowName", WindowName);
            info.AddValue("heightWindow", HeightWindow);
            info.AddValue("widthWindow", WidthWindow);
            info.AddValue("topWindow", TopWindow);
            info.AddValue("leftwindow", LeftWindow);
        }

        #endregion
    }
}
