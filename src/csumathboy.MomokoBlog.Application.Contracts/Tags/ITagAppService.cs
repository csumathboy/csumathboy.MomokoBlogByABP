using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace csumathboy.MomokoBlog.Tags
{
    public interface ITagAppService :
        ICrudAppService<TagDto, Guid, PagedAndSortedResultRequestDto, CreateTagDto, UpdateTagDto>
    {

    }
}
