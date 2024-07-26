using csumathboy.MomokoBlog.Posts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace csumathboy.MomokoBlog.Posts
{
    public class CreatePostDto
    {
        [Required]
        [StringLength(PostConsts.MaxTitleLength)]
        public string Title { get; set; } = default!;
        [Required]
        [StringLength(PostConsts.MaxAuthorLength)]
        public string Author { get; set; } = default!;

        public string? Description { get; set; }

        public Guid ClassId { get; set; }

        public string ContextValue { get; set; } = default!;

        public string? Picture { get; set; }

        public int Sort { get; set; } = 0;

        public bool IsTop { get; set; } = false;

        public PostStatus PostsStatus { get; set; }

        public string[] PostTagNames { get; set; } = default!;

    }
}
