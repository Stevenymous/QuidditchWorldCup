using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

/// <summary>
/// Service sur les matches permettant de tous les récupérer
/// </summary>
[ServiceContract]
public interface IServiceMatch
{
    /// <summary>
    /// Operation permettant d'obtenir la liste de tous les matches
    /// </summary>
    /// <returns></returns>
	[OperationContract]
    IList<QuidditchWebServices.Match> GetAllMatches();
}
