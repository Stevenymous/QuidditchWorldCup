using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using QuidditchBusinessLayer;
using QuidditchPresentationLayerWPF.ViewModel;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Interaction logic for WindowMatch.xaml
    /// </summary>
    public partial class WindowMatch : Window
    {
        /// <summary>
        /// Constructeur de WindowMatch
        /// </summary>
        public WindowMatch()
        {
            InitializeComponent();
            SetDimensionAndPosition();
        }

        /// <summary>
        /// Sauvegarde la position et les dimensions de la fenêtre
        /// </summary>
        private void SaveDimensionAndPosition(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ManagerPersistenceDimensionAndPosition managerDimensionAndPosition =
                            new ManagerPersistenceDimensionAndPosition();
            DimensionAndPosition dimAndPos = new DimensionAndPosition(this.Height, this.Width, this.Top, this.Left, "WindowMatch");
            managerDimensionAndPosition.SerializeDimensionAndPosition(dimAndPos);
        }

        /// <summary>
        /// Défini la position et les dimensions de la fenêtre
        /// </summary>
        private void SetDimensionAndPosition()
        {
            ManagerPersistenceDimensionAndPosition managerDimensionAndPosition =
                            new ManagerPersistenceDimensionAndPosition();
            DimensionAndPosition dimAndPos;
            dimAndPos = managerDimensionAndPosition.DeserializeDimensionAndPosition("WindowMatch");
            this.Height = dimAndPos.HeightWindow;
            this.Width = dimAndPos.WidthWindow;
            this.Top = dimAndPos.TopWindow;
            this.Left = dimAndPos.LeftWindow;
        }

        /// <summary>
        /// Charge les données du Business dans le ViewModel associé à cette vue
        /// </summary>
        /// <param name="sender">L'objet ayant envoyé l'événement</param>
        /// <param name="e">Les arguments d'événments</param>
        private void Load(object sender, RoutedEventArgs e)
        {
            IBusinessManager businessManager = FabriqueBusinessManager.ConstruireBusinessManager("database");
            ModelManager modelManager = new ModelManager(businessManager.GetAllMatches());
            IList<IEquipe> equipes = new List<IEquipe>();
            businessManager.GetAllEquipes().ToList().ForEach(equipe => {
                equipes.Add(FabriqueEquipe.FabriquerEquipe(equipe));
            });
            IList<IStade> stades = new List<IStade>();
            businessManager.GetAllStades().ToList().ForEach(stade =>
            {
                stades.Add(FabriqueStade.FabriquerStade(stade));
            });

            IList<IArbitre> arbitres = new List<IArbitre>();
            businessManager.GetAllArbitres().ToList().ForEach(arbitre =>
            {
                arbitres.Add(FabriqueArbitre.FabriquerArbitre(arbitre));
            });

            MatchesViewModel matchesViewModel = new MatchesViewModel(modelManager.Matches, equipes, stades, arbitres);
            DataContext = matchesViewModel;
        }       
    }
}
