using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchPresentationLayer
{
    /// <summary>
    /// Permet d'éxécuter l'application console
    /// </summary>
    class Program
    {
        /// <summary>
        /// Méthode Main
        /// </summary>
        /// <param name="args">Arguments passés au programme</param>
        static void Main(string[] args)
        {
            IPresentationManager presentationManager = FabriquePresentationManager.ConstruirePresentationManager();
            IMenuManager menuManager = FabriqueMenuManager.ConstruireMenuManager(presentationManager);
            menuManager.GetChoiceFromUser();
        }
    }
}
