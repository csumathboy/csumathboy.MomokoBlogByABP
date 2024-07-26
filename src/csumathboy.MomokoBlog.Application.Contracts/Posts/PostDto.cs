using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace csumathboy.MomokoBlog.Posts
{
    public class PostDto : EntityDto<Guid>
    {
        public string Title { get; set; } = default!;

        public string Author { get; set; } = default!;

        public string? Description { get; set; }

        public Guid ClassId { get; set; }

        public string? Picture { get; set; }

        public int Sort { get; set; } = 0;

        public bool IsTop { get; set; } = false;

        public string[] PostTagNames { get; set; } = default!;

        public PostStatus PostsStatus { get; set; }
    }
}
