using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuidditchWebServices
{
    /// <summary>
    /// Enumération sur les postes des joueurs dans une équipe de quidditch
    /// </summary>
    [FlagsAttribute]
    [DataContract]
    public enum Poste
    {
        [EnumMember()]
        None,
        [EnumMember()]
        Batteur,
        [EnumMember()]
        Gardien,
        [EnumMember()]
        Attrapeur,
        [EnumMember()]
        Poursuiveur
    }
}
