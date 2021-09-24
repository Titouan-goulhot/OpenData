using dll;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
   public class Transports
    {
        IRequest _request;

        // Constructor 
        public Transports(bool connected)
        {
            if (connected)
            {
                _request = new Request();
            }
            else
            {
                 _request = new RequestOffline();
            }

        }

        public Transports(IRequest request)
        {
            _request = request;
        }


        //Méthode 
        public List<Root> GetStation()
        {
          string json = _request.DoRequest();

           List<Root> transports =  JsonConvert.DeserializeObject<List<Root>>(json);

            return transports;
        }

        

    }
}
