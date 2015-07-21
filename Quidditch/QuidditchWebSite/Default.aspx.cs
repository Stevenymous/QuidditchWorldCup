using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuidditchWebServices;
using QuidditchWebSite;

/// <summary>
/// Classe partielle représentant la Page ASP affichée
/// </summary>
public partial class _Default : Page
{
    /// <summary>
    /// Objet aléatoire générant les prix pour les réservations
    /// </summary>
    private static Random rand = new Random();

    /// <summary>
    /// Liste des matches récupérés depuis le web service
    /// </summary>
    private IList<QuidditchWebSite.Match> matches = new List<QuidditchWebSite.Match>();

    /// <summary>
    /// Evénement déclenché au chargement de la page
    /// </summary>
    /// <param name="sender">Objet ayant envoyé l'événement</param>
    /// <param name="e">Arguments d'événement</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        List<float> generatedPrix = new List<float>();
        for (int i = 0; i < 5; i++)
		{
		    generatedPrix.Add((float) Math.Round(rand.NextDouble() * rand.Next(100) + 50, 2));
	    }
        generatedPrix.Sort();
        generatedPrix.ForEach(prix =>
        {
            DdlPrix.Items.Add(new ListItem(String.Format("{0} €", Convert.ToString(prix))));
        });

        LoadMatches();
    }
    
    /// <summary>
    /// Evénement déclenché lors du clic sur le bouton Réserver
    /// </summary>
    /// <param name="sender">Objet ayant envoyé l'événement</param>
    /// <param name="e">Arguments d'événements</param>
    protected void BtnReserver_Click(object sender, EventArgs e)
    {
        string selectedMatch = RbList.SelectedValue;
        string numberPlace = TxbPlace.Text;
        string selectedPrix = DdlPrix.SelectedValue;
        Reservation reservationCreated = new Reservation();
        reservationCreated.Place = Convert.ToInt32(numberPlace);
        reservationCreated.Prix = (float) Convert.ToDouble(selectedPrix.Split(new char[]{' '})[0]) * reservationCreated.Place;

        ServiceReservationClient serviceReservation = null;
        try
        {
            serviceReservation = new ServiceReservationClient();
            if (-1 == serviceReservation.AddReservation(reservationCreated, 
                matches.Where(match => match.ToString() == selectedMatch).ToList()[0].Identifiant))
            {
                LbResultAdd.Text = "Le match est complet, impossible de réserver une place";
            }
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            RbList.Items.Clear();
            LoadMatches();
            if (serviceReservation != null)
            {
                serviceReservation.Close();
            }
        }
        LbResultAdd.Text = "Réservation bien enregistrée";
    }

    /// <summary>
    /// Permet de charger les matches depuis le web services
    /// </summary>
    private void LoadMatches()
    {
        ServiceMatchClient clientMatch = null;
        try
        {
            clientMatch = new ServiceMatchClient();
            clientMatch.GetAllMatches().ToList().ForEach(match =>
            {
                matches.Add((QuidditchWebSite.Match)FabriqueMatch.FabriquerMatch(match));
                RbList.Items.Add(new ListItem(FabriqueMatch.FabriquerMatch(match).ToString()));
            });
        }
        catch (Exception ex)
        {
            LbListMatch.Text = "Erreur : Impossible de charger la liste des matches";
            BtnReserver.Enabled = false;
        }
        finally
        {
            if (clientMatch != null)
            {
                clientMatch.Close();
            }
        }
    }
}