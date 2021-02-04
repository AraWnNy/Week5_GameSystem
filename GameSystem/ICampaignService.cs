using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    interface ICampaignService
    {
        void Add();
        void Delete();
        void Update(long campaignPercentage);
    }
}
