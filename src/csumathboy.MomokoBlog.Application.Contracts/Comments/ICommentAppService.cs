using csumathboy.MomokoBlog.Tags;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace csumathboy.MomokoBlog.Comments
{


    public interface ICommentAppService :
        ICrudAppService<CommentDto, Guid, PagedAndSortedResultRequestDto, CreateCommentDto, UpdateCommentDto>
    {

    }
}
