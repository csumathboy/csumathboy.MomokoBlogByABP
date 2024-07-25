using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace csumathboy.MomokoBlog.Classifications
{
    public interface IClassificationAppService : IApplicationService
    {
        Task<ClassificationDto> GetAsync(Guid id);

        Task<PagedResultDto<ClassificationDto>> GetListAsync(GetClassificationListDto input);

        Task<ClassificationDto> CreateAsync(CreateClassificationDto input);

        Task UpdateAsync(Guid id, UpdateClassificationDto input);

        Task DeleteAsync(Guid id);
    }
}
