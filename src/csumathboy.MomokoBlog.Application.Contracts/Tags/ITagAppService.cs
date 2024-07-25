using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace csumathboy.MomokoBlog.Tags
{
    public interface ITagAppService : IApplicationService
    {
        Task<TagDto> GetAsync(Guid id);

        Task<PagedResultDto<TagDto>> GetListAsync(GetTagListDto input);

        Task<TagDto> CreateAsync(CreateTagDto input);

        Task UpdateAsync(Guid id, UpdateTagDto input);

        Task DeleteAsync(Guid id);
    }
}
