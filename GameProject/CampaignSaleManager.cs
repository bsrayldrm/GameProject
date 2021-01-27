using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignSaleManager
    {
        public void CampaignSale(Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName + " " + "oyunu için  01.02.2021 tarihine kadar" + " " + campaign.CampaignName + " " + " kampanyasından faydalanabilirsiniz.Kampanya kodu:" + " " + campaign.CampaignCode);
        }
    }
}
