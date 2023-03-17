using System;
namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanya Eklendi.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}

