using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuidditchBusinessLayer
{
    /// <summary>
    /// Exception permettant d'indiquer qu'un match à son nombre de places dans le stade déjà resérvées
    /// </summary>
    public class MatchOverbookException : Exception
    {
    }
}
