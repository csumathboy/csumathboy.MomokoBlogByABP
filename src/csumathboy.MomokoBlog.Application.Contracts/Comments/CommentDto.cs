using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace csumathboy.MomokoBlog.Comments
{
    public class CommentDto : EntityDto<Guid>
    {
        public string Title { get; set; } = default!;
        public Guid PostsId { get; set; }
        public string Description { get; set; } = default!;
        public string RealName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
    }
}
