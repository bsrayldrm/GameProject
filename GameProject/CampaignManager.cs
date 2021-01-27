using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager
    {
        public void Add(Campaign campaign)
        {

            Console.WriteLine(campaign.CampaignName +" " + "kampanyası eklendi." +"indirim kodu:" + campaign.CampaignCode);
        }

        public void Update(Campaign campaign)
        {

            Console.WriteLine(campaign.CampaignName +" "+ "kampanyası güncellendi."+"Yeni indirim oranı %"+ campaign.CampaignDiscount);
        }

        public void Delete(Campaign campaign)
        {

            Console.WriteLine(campaign.CampaignName + " "+ "kampanyası sistemden kaldırılmıştır.");
        }

    }
}
