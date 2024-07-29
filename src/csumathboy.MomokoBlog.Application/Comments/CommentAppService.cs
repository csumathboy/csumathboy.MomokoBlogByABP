using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace csumathboy.MomokoBlog.Comments;


public class CommentAppService :
    CrudAppService<Comment, CommentDto, Guid, PagedAndSortedResultRequestDto, CreateCommentDto, UpdateCommentDto>,
    ICommentAppService
{
    public CommentAppService(IRepository<Comment, Guid> repository) : base(repository)
    {
    }
}
