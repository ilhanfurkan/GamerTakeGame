using GamerTakeGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerTakeGame.Abstract
{
    internal interface ICampaignService
    {
        void CInput(Campaign campaign, Games game);
        void CUpdate(Campaign campaign,double newcampign,Games game);
        void CRemove(Campaign campaign, Games game);
    }
}
