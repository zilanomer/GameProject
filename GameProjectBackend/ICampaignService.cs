﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackend
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);

        void Remove(Campaign campaign);

        void Update(Campaign campaign);

        void Delete(Campaign campaign);
    }
}
