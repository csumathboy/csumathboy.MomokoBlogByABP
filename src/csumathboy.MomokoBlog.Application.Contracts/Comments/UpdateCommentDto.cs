using csumathboy.MomokoBlog.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace csumathboy.MomokoBlog.Comments
{
    public class UpdateCommentDto
    {
        [Required]
        [StringLength(CommentConsts.MaxNameLength)]
        public string Title { get; set; } = default!;
        public Guid PostsId { get; set; }
        public string Description { get; set; } = default!;
        public string RealName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
    }
}
