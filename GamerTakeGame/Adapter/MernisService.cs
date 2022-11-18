using GamerTakeGame.Abstract;
using GamerTakeGame.Entities;
using MernisServiceAdapterr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceAdapterr.KPSPublicSoapClient;

namespace GamerTakeGame.Adapter
{
    internal class MernisService : IGamerCheckService
    {
        public bool CheckGamerOnMernis(Gamers gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalId),gamer.Name.ToUpper(),gamer.LastName.ToUpper(),gamer.DateofBirth.Year);
            bool lastTry = result.Result.Body.TCKimlikNoDogrulaResult;
            return lastTry;
        }
    }
}
