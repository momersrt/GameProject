using System;
namespace GameProject
{
    public class SalesManager : ISalesService
    {
        SaleOfGameWithCampaign _saleOfGameWithCampaign;

        public SalesManager(SaleOfGameWithCampaign saleOfGameWithCampaign)
        {
            _saleOfGameWithCampaign = saleOfGameWithCampaign;
        }

        public void Sale(Gamer gamer, Campaign campaign)
        {
            if (_saleOfGameWithCampaign.WithCampaign(campaign))
            {
                Console.WriteLine("Sayın " + gamer.FirstName + "," + campaign.CampaignName + " Kampanyasıyla Oyun Alımı Gerçekleşti.");
            }
            else
            {
                Console.WriteLine("Sayın " + gamer.FirstName + " Oyun Alımı Gerçekleşti");
            }
            
        }
    }
}

