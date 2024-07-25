using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace csumathboy.MomokoBlog.Classifications
{
    public class GetClassificationListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
