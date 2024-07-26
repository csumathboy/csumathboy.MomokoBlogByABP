using csumathboy.MomokoBlog.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace csumathboy.MomokoBlog.Tags
{
    public class UpdateTagDto
    {
        [Required]
        [StringLength(TagConsts.MaxNameLength)]
        public string Name { get; set; } = default!;
        public string? NickName { get; set; }
        public int ArtCount { get; set; }
    }
}
