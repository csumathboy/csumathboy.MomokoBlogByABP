using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace csumathboy.MomokoBlog.Tags;
public class TagAppService :
    CrudAppService<Tag, TagDto, Guid, PagedAndSortedResultRequestDto, CreateTagDto, UpdateTagDto>,
    ITagAppService
{
    public TagAppService(IRepository<Tag, Guid> repository) : base(repository)
    {
    }
}
