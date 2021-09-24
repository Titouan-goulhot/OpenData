using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll;

namespace OpenData.Tests
{
  public  class FakeRequest : IRequest
    {

        public FakeRequest(bool connected)
        {

        }

        //Mehods
        public string DoRequest()
        {
            return "[{\"id\":\"SEM:0844\",\"name\":\"Grenoble, Champs-Elys\u00e9es\",\"lon\":5.71025,\"lat\":45.17794,\"zone\":\"SEM_GENCHAMPSEL\",\"lines\":[\"SEM:12\"]},{\"id\":\"SEM:0846\",\"name\":\"Grenoble, Salengro\",\"lon\":5.70893,\"lat\":45.17557,\"zone\":\"SEM_GENSALENGRO\",\"lines\":[\"SEM:12\"]},{\"id\":\"SEM:0847\",\"name\":\"Grenoble, Salengro\",\"lon\":5.70887,\"lat\":45.17566,\"zone\":\"SEM_GENSALENGRO\",\"lines\":[\"SEM:12\"]}]";
        }
    }
}
