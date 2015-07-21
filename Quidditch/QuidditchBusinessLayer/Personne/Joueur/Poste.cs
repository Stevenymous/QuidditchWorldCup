using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Enumération sur les postes des joueurs dans une équipe de quidditch
    /// </summary>
    [FlagsAttribute]
    public enum Poste
    {
        None,
        Batteur,
        Gardien,
        Attrapeur,
        Poursuiveur
    }
}
