using System.ComponentModel.DataAnnotations;

namespace csumathboy.MomokoBlog.Classifications
{
    public class CreateClassificationDto
    {
        [Required]
        [StringLength(ClassificationConsts.MaxNameLength)]
        public string Name { get; set; } = default!;

        public string? Description { get; set; }
        public string? NickName { get; set; }
        public int ArtCount { get; set; }
    }
}
