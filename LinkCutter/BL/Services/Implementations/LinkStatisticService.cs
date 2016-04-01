using BL.Services.Contracts;
using DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Implementations
{
    public class LinkStatisticService : BaseService, ILinkStatisticService
    {
        ILinkRepo _linkRepo;
        public LinkStatisticService(ILinkRepo linkRepo)
        {
            _linkRepo = linkRepo;
        }
        public void IncrementLinkStat(int linkId)
        {
            Task.Factory.StartNew(() =>
            {
                var link = _linkRepo.Get(linkId);
                link.Visitors++;
                _linkRepo.Update(link);

            }).ConfigureAwait(false);
        }
    }
}
