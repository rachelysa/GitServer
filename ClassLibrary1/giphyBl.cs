using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using System.Linq;
using PhoneNumbers;
using PhoneNumber = PhoneNumbers.PhoneNumber;

namespace ClassLibrary1
{
    public class giphyBl

    {
        public async Task<object> searchGif(string search)
        {
            var giphy = new Giphy("Nkq0WXG5eGKlDsSJ6bio5NVhnwP5FL8O");
            var searchParameter = new SearchParameter()
            {
                Query = search
            };

            var gifResult = await giphy.GifSearch(searchParameter);
            return gifResult.Data;
        }



    }
}
