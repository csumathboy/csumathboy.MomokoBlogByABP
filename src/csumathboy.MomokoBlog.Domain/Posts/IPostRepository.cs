using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace csumathboy.MomokoBlog.Posts
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<PostWithDetails>> GetListAsync(
            string sorting,
            int skipCount,
            int maxResultCount,
            CancellationToken cancellationToken = default
        );

        Task<PostWithDetails> GetAsync(Guid id, CancellationToken cancellationToken = default);
    }
}