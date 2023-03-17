namespace GameProject;
class Program
{
    static void Main(string[] args)
    {
        Campaign campaign1 = new Campaign();
        campaign1.CampaignId = 1;
        campaign1.CampaignName = "Bahar İndirimi";
        campaign1.CampaignDiscount = 20;

        Gamer gamer1 = new Gamer();
        gamer1.BirthYear = 1998;
        gamer1.FirstName = "Ömer";
        gamer1.LastName = "Sert";
        gamer1.NationalityId = "123456";

        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        gamerManager.Add(gamer1);
        CampaignManager campaignManager = new CampaignManager();
        campaignManager.AddCampaign(campaign1);
        SalesManager salesManager = new SalesManager(new SaleOfGameWithCampaign());
        salesManager.Sale(gamer1,campaign1);


    }
}

