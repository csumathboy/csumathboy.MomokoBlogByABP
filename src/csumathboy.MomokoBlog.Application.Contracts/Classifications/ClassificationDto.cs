using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace csumathboy.MomokoBlog.Classifications
{
    public class ClassificationDto : EntityDto<Guid>
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string? NickName { get; set; }
        public int ArtCount { get; set; }
    }
}
