using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace csumathboy.MomokoBlog.Tags
{
    public class GetTagListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
