using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace csumathboy.MomokoBlog.Tags
{
    public class TagDto : EntityDto<Guid>
    {
        public string Name { get; set; } = default!;
        public string? NickName { get; set; }
        public int ArtCount { get; set; }
    }
}
