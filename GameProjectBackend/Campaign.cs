using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackend
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime DeadLine { get; set; }
        public double DiscountRate { get; set; }
    }
}
