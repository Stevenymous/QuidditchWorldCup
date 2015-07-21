using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// A pour responsabilité de gérer la persistance de l'objet DimensionAndPosition
    /// </summary>
    internal class ManagerPersistenceDimensionAndPosition
    {
        #region Constants

        /// <summary>
        /// Nom du fichier où sera stocker les dimensions et la position de la fenêtre
        /// </summary>
        private const string FILE_NAME = "dimensionAndPositionWindow";

        #endregion

        #region Fields

        /// <summary>
        /// Instance du fichier stocké dans l'espace de persistance isolé
        /// </summary>
        private IsolatedStorageFile _storageFile;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut de ManagerPersistenceDimensionAndPosition
        /// </summary>
        public ManagerPersistenceDimensionAndPosition()
        {
            IsolatedStorageFile storageFile = null;
            storageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Roaming
                | IsolatedStorageScope.Assembly | IsolatedStorageScope.Domain, null, null);
        }

        #endregion

        #region Operations

        /// <summary>
        /// Sérialise dans un fichier l'objet DimensionAndPosition 
        /// </summary>
        /// <param name="dimAndPos">L'objet à sérialiser</param>
        public void SerializeDimensionAndPosition(DimensionAndPosition dimAndPos)
        {
            IsolatedStorageFileStream storageFileStream = null;
            storageFileStream = new IsolatedStorageFileStream(String.Format(FILE_NAME + "{0}", dimAndPos.WindowName),
                System.IO.FileMode.Create, _storageFile);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(storageFileStream, dimAndPos);
            storageFileStream.Close();
        }

        /// <summary>
        /// Déserialise un objet DimensionAndPosition
        /// </summary>
        /// <returns>L'objet déserialisé</returns>
        public DimensionAndPosition DeserializeDimensionAndPosition(string windowName)
        {
            IsolatedStorageFileStream storageFileStream = null;
            storageFileStream = new IsolatedStorageFileStream(String.Format(FILE_NAME + "{0}", windowName),
                System.IO.FileMode.Open, _storageFile);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            object dimAndPos = binaryFormatter.Deserialize(storageFileStream);
            storageFileStream.Close();
            return (DimensionAndPosition) dimAndPos;
        }

        #endregion
    }
}
