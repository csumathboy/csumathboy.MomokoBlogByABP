using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using csumathboy.MomokoBlog.Classifications;
using System.Collections.ObjectModel;
using csumathboy.MomokoBlog.Tags;
using System.Xml.Linq;
using Volo.Abp;
using System.Linq;

namespace csumathboy.MomokoBlog.Posts;

public class Post : FullAuditedAggregateRoot<Guid>
{
    public string Title { get; set; } = default!;

    public string Author { get; set; } = default!;

    public string? Description { get; set; }
 

    public Guid ClassId { get; set; }

    public string ContextValue { get; set; } = default!;

    public string? Picture { get; set; } 

    public int Sort { get; set; } = 0;

    public bool IsTop { get; set; } = false;

    public  ICollection<PostTag> PostTags { get; private set; }= new Collection<PostTag>();

    public PostStatus PostsStatus { get; set; }

    /* This constructor is for deserialization / ORM purpose */
    public Post()
    {

    }

    public Post(string title, Guid classId, string author, string description, string contextValue, string picture, int sort, bool isTop, PostStatus postsStatus)
    {
        Title = Check.NotNullOrWhiteSpace(title, nameof(title), PostConsts.MaxTitleLength);
        ClassId = classId;
        Author = Check.NotNullOrWhiteSpace(author, nameof(author), PostConsts.MaxAuthorLength);
        Description = Check.Length(description, nameof(description), PostConsts.MaxDescriptionLength);
        ContextValue = contextValue;
        Picture = Check.Length(picture, nameof(picture), PostConsts.MaxImageUrlLength);
        Sort = sort;
        IsTop = isTop;
        PostsStatus = postsStatus;
    }

    public void AddPostTag(Guid tagId)
    {
        Check.NotNull(tagId, nameof(tagId));

        if (IsInPostTag(tagId))
        {
            return;
        }

        PostTags.Add(new PostTag(postId: Id, tagId));
    }

    public void RemovePostTag(Guid tagId)
    {
        Check.NotNull(tagId, nameof(tagId));

        if (!IsInPostTag(tagId))
        {
            return;
        }

        PostTags.RemoveAll(x => x.TagId == tagId);
    }

    public void RemoveAllPostTagsExceptGivenIds(List<Guid> tagIds)
    {
        Check.NotNullOrEmpty(tagIds, nameof(tagIds));

        PostTags.RemoveAll(x => !tagIds.Contains(x.TagId));
    }

    public void RemoveAllPostTags()
    {
        PostTags.RemoveAll(x => x.PostId == Id);
    }

    private bool IsInPostTag(Guid tagId)
    {
        return PostTags.Any(x => x.PostId == tagId);
    }

    public Post ClearImagePath()
    {
        Picture = string.Empty;
        return this;
    }

    public void UpdateTitle(string newTitle)
    {
        Title = Check.NotNullOrWhiteSpace(newTitle, nameof(newTitle), PostConsts.MaxTitleLength);
    }

    public void UpdateClassification(Guid newClassId)
    {
        ClassId = newClassId;
    }

    public void UpdateAuthor(string newAuthor)
    {
        Author = Check.NotNullOrWhiteSpace(newAuthor, nameof(newAuthor), PostConsts.MaxAuthorLength);
    }

    public void UpdateDescription(string newDescription)
    {
        Description = Check.Length(newDescription, nameof(newDescription), PostConsts.MaxTitleLength);
    }

    public void UpdateContextValue(string newContextValue)
    {
        ContextValue = newContextValue;
    }

    public void UpdatePicture(string newPicture)
    {
        Picture = Check.Length(newPicture, nameof(newPicture), PostConsts.MaxImageUrlLength); ;
    }

    public void UpdateSort(int newSort)
    {
        Sort = newSort;
    }

    public void UpdateIsTop(bool newIsTop)
    {
        IsTop = newIsTop;
    }

    public void UpdatePostsStatus(PostStatus newPostsStatus)
    {
        PostsStatus = newPostsStatus;
    }
}
