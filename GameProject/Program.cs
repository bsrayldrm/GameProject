using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer() { FirstName = "Hazin", LastName = "Yıldırım", DateOfBirth = new DateTime(1964, 3, 23), Id = 4, NationalityId = "147963258" };
            Customer customer2 = new Customer() { FirstName = "Buket", LastName = "Erol", DateOfBirth = new DateTime(1990, 9, 26), Id = 2, NationalityId = "18954712" };
            customerManager.Save(customer1);
            customerManager.Update(customer2);

            CampaignManager campaignManager = new CampaignManager(); 
            Campaign campaign = new Campaign();
            campaign.CampaignCode = "154896";
            campaign.CampaignName = "Ocak indirimi";
            campaign.CampaignDiscount = 50;

            campaignManager.Add(campaign);

            Game game1 = new Game();
            game1.GameName = "Football Manager";
            game1.GameType = "Sport";
            game1.GamePrice = 260;
            Game game2 = new Game();
            game2.GameName = "Call Of Duty";
            game2.GameType = "FPS";
            game2.GamePrice = 150;


            SaleManager saleManager = new SaleManager();
            saleManager.Sale(customer2, game1);

            CampaignSaleManager campaignSaleManager = new CampaignSaleManager();
            campaignSaleManager.CampaignSale(campaign, game2);
           



















        }
    }
}
