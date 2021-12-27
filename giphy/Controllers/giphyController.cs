using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Services;

namespace giphy.Controllers
{

    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
  
    public class GiphyController : ApiController
    {
        GiphyBL giphyBl = new GiphyBL();

        // GET: api/Default/5
        public async Task<object> Get(string id)
        {
            var gifs = await giphyBl.SearchGif(id);

            return gifs;
        }

       
    }
}
