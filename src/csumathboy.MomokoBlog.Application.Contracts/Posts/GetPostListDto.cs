﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace csumathboy.MomokoBlog.Posts
{
    public class GetPostListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
