﻿using System;
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

namespace QuidditchPresentationLayerWPF
{
    /// <summary>
    /// Interaction logic for WindowMatchesExpectedOrderByDate.xaml
    /// </summary>
    public partial class WindowMatchesExpectedOrderByDate : Window
    {
        /// <summary>
        /// Constructeur de la fenetre
        /// </summary>
        public WindowMatchesExpectedOrderByDate()
        {
            InitializeComponent();
            SetDimensionAndPosition();
        }

        /// <summary>
        /// Evénement déclenché au lancement de la fenêtre
        /// </summary>
        /// <param name="sender">Objet ayant envoyé l'événement</param>
        /// <param name="e">Arguments d'événements</param>
        private void LoadData(object sender, EventArgs e)
        {
            IBusinessManager businessManager = FabriqueBusinessManager.ConstruireBusinessManager("database");
            this.listMatches.ItemsSource = businessManager.GetMatchsExpectedOrderByDate();
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
            DimensionAndPosition dimAndPos = new DimensionAndPosition(this.Height, this.Width, this.Top, this.Left, "WindowMatchesExpectedOrderByDate");
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
            dimAndPos = managerDimensionAndPosition.DeserializeDimensionAndPosition("WindowMatchesExpectedOrderByDate");
            this.Height = dimAndPos.HeightWindow;
            this.Width = dimAndPos.WidthWindow;
            this.Top = dimAndPos.TopWindow;
            this.Left = dimAndPos.LeftWindow;
        }       
    }
}
