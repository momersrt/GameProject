using System;
namespace GameProject
{
	public interface ICampaignService
	{
		void AddCampaign(Campaign campaign);
		void DeleteCampaign(Campaign campaign);
		void UpdateCampaign(Campaign campaign);
	}
}

