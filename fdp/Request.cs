using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public class Request : IRequest
    {
        public string DoRequest()
        {
            //WebRequest : Effectue une demande à un URI   //Create : Initialise une nouvelle instance de WebRequest pour le modèle d'URI spécifié.

            WebRequest request = WebRequest.Create("http://data.mobilites-m.fr/api/linesNear/json?x=5.709360123&y=45.176494599999984&dist=400&details=true");

            // WebResponse: Fournit une réponse provenant d'un URI
            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            return reader.ReadToEnd();

        }
    }
}
