using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchDataAccessLayer
{
    /// <summary>
    /// Implémentation du manager de la data acces layer de Joueur
    /// </summary>
    internal class StubDalManagerJoueur : IDalManagerJoueur
    {
        /// <summary>
        /// Permet de retourner la liste de tous les joueurs existants
        /// </summary>
        /// <returns>La liste des joueurs existants</returns>
        public IList<IJoueur> ObtenirJoueurs()
        {
            IList<IJoueur> joueurs = new List<IJoueur>();
            joueurs.Add(FabriqueJoueur.CreerJoueur(0, "Jean", "Neymard", "21/08/1991", false, "Attrapeur", 45));
            joueurs.Add(FabriqueJoueur.CreerJoueur(1, "Dupont", "Ton", "04/05/1990", false, "Gardien", 71));
            joueurs.Add(FabriqueJoueur.CreerJoueur(2, "Damien", "Erka", "09/11/1987", true, "Poursuiveur", 36));
            joueurs.Add(FabriqueJoueur.CreerJoueur(3, "Pacal", "Hemaya", "17/02/1990", false, "Batteur", 23));
            joueurs.Add(FabriqueJoueur.CreerJoueur(4, "Jonathan", "Mendelsohn", "15/12/1988", false, "Poursuiveur", 74));
            joueurs.Add(FabriqueJoueur.CreerJoueur(5, "Dimitri", "Vegas", "25/05/1990", false, "Poursuiveur", 112));
            joueurs.Add(FabriqueJoueur.CreerJoueur(6, "Like", "Mike", "04/08/1988", false, "Batteur", 120));

            joueurs.Add(FabriqueJoueur.CreerJoueur(7, "Armin", "Van Buuren", "14/07/1982", true, "Attrapeur", 97));
            joueurs.Add(FabriqueJoueur.CreerJoueur(8, "Brennan", "Heart", "02/12/1999", false, "Gardien", 114));
            joueurs.Add(FabriqueJoueur.CreerJoueur(9, "Oliver", "Heldens", "17/01/1993", false, "Poursuiveur", 54));
            joueurs.Add(FabriqueJoueur.CreerJoueur(10, "Julian", "Jordan", "29/08/1994", false, "Batteur", 142));
            joueurs.Add(FabriqueJoueur.CreerJoueur(11, "Sander", "Van Doorn", "09/10/1979", false, "Poursuiveur", 40));
            joueurs.Add(FabriqueJoueur.CreerJoueur(12, "Don", "Diablo", "30/03/1991", false, "Poursuiveur", 51));
            joueurs.Add(FabriqueJoueur.CreerJoueur(13, "Eelke", "Klejn", "04/02/1985", false, "Batteur", 87));
            return joueurs;
        }
    }
}
