using csumathboy.MomokoBlog.Classifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace csumathboy.MomokoBlog.Classifications
{
    public class UpdateClassificationDto
    {
        [Required]
        [StringLength(ClassificationConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }
    }
}
