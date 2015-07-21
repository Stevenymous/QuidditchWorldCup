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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetDimensionAndPosition();
        }

        /// <summary>
        /// Evénement d'ouverture de la fenêtre affichant les matches
        /// </summary>
        /// <param name="sender">Objet ayant enviyé l'évènement</param>
        /// <param name="e">Arguments d'évènements</param>
        private void OpenWindowMatch(object sender, RoutedEventArgs e)
        {
            Window windowMatch = new WindowMatch();
            windowMatch.ShowDialog();
        }

        /// <summary>
        /// Evénement d'ouverture de la fenêtre affichant les coupes
        /// </summary>
        /// <param name="sender">Objet ayant enviyé l'évènement</param>
        /// <param name="e">Arguments d'évènements</param>
        private void OpenWindowDisplayAllCoupes(object sender, RoutedEventArgs e)
        {
            Window windowDisplayAllCoupes = new WindowAllCoupes();
            windowDisplayAllCoupes.ShowDialog();
        }

        /// <summary>
        /// Evénement d'ouverture de la fenêtre affichant les matches
        /// </summary>
        /// <param name="sender">Objet ayant enviyé l'évènement</param>
        /// <param name="e">Arguments d'évènements</param>
        private void OpenWindowDisplayMatchesExpectedOrderByDate(object sender, RoutedEventArgs e)
        {
            Window matchesExpectedOrderByDate_Click = new WindowMatchesExpectedOrderByDate();
            matchesExpectedOrderByDate_Click.ShowDialog();
        }

        /// <summary>
        /// Evénement d'ouverture de la fenêtre affichant les stades
        /// </summary>
        /// <param name="sender">Objet ayant enviyé l'évènement</param>
        /// <param name="e">Arguments d'évènements</param>
        private void OpenWindowStadesWhereOneOrMoreMatchIsExpected(object sender, RoutedEventArgs e)
        {
            Window stadesWhereOneOrMoreMatchIsExpected = new WindowStadesWhereOneOrMoreMatchIsExpected();
            stadesWhereOneOrMoreMatchIsExpected.ShowDialog();
        }

        /// <summary>
        /// Evénement d'ouverture de la fenêtre affichant les joueurs 
        /// </summary>
        /// <param name="sender">Objet ayant enviyé l'évènement</param>
        /// <param name="e">Arguments d'évènements</param>
        private void OpenWindowPlayersWhoIsAttrapeurAndTheyPlayedAtHome(object sender, RoutedEventArgs e)
        {
            Window windowPlayersWhoIsAttrapeurAndTheyPlayedAtHome = new WindowPlayersWhoIsAttrapeurAndTheyPlayedAtHome();
            windowPlayersWhoIsAttrapeurAndTheyPlayedAtHome.ShowDialog();
        }

        /// <summary>
        /// Evénement d'ouverture de la fenêtre affichant les joueurs 
        /// </summary>
        /// <param name="sender">Objet ayant enviyé l'évènement</param>
        /// <param name="e">Arguments d'évènements</param>
        private void OpenWindowDisplayPlayerWhoIsGardienAndTheyAreYoungerThanSeventeen(object sender, RoutedEventArgs e)
        {
            Window windowDisplayPlayerWhoIsGardienAndTheyAreYoungerThanSeventeen = new WindowDisplayPlayerWhoIsGardienAndTheyAreYoungerThanSeventeen();
            windowDisplayPlayerWhoIsGardienAndTheyAreYoungerThanSeventeen.ShowDialog();
        }

        /// <summary>
        /// Evénement de sauvegarde des dimensions et des positions
        /// </summary>
        /// <param name="sender">Objet ayant enviyé l'évènement</param>
        /// <param name="e">Arguments d'évènements</param>
        private void SaveDimensionAndPosition(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ManagerPersistenceDimensionAndPosition managerDimensionAndPosition =
                            new ManagerPersistenceDimensionAndPosition();
            DimensionAndPosition dimAndPos = new DimensionAndPosition(this.Height, this.Width, this.Top, this.Left, "MainWindow");
            managerDimensionAndPosition.SerializeDimensionAndPosition(dimAndPos);
        }

        /// <summary>
        /// Permet de définir les dimensions et les positions de la fenêtre
        /// </summary>
        private void SetDimensionAndPosition()
        {
            ManagerPersistenceDimensionAndPosition managerDimensionAndPosition =
                            new ManagerPersistenceDimensionAndPosition();
            DimensionAndPosition dimAndPos;
            dimAndPos = managerDimensionAndPosition.DeserializeDimensionAndPosition("MainWindow");
            this.Height = dimAndPos.HeightWindow;
            this.Width = dimAndPos.WidthWindow;
            this.Top = dimAndPos.TopWindow;
            this.Left = dimAndPos.LeftWindow;
        }

    }
}
