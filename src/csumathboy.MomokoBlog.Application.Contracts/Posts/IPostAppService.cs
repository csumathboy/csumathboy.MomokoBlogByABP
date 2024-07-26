using csumathboy.MomokoBlog.Classifications;
using csumathboy.MomokoBlog.Tags;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace csumathboy.MomokoBlog.Posts
{
    public interface IPostAppService : IApplicationService
    {
        Task<PostDto> GetAsync(Guid id);

        Task<PagedResultDto<PostDto>> GetListAsync(GetPostListDto input);

        Task<PostDto> CreateAsync(CreatePostDto input);

        Task UpdateAsync(Guid id, UpdatePostDto input);

        Task DeleteAsync(Guid id);

        Task<ListResultDto<ClassificationDto>> GetClassificationAsync();

        Task<ListResultDto<TagDto>> GetTagAsync();
    }
}
