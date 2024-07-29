
using AutoMapper.Internal.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using csumathboy.MomokoBlog.Tags;
using csumathboy.MomokoBlog.Classifications;

namespace csumathboy.MomokoBlog.Posts;


public class PostAppService : csumathboy.MomokoBlog.MomokoBlogAppService, IPostAppService
{
    private readonly IPostRepository _postRepository;
    private readonly PostManager _postManager;
    private readonly IRepository<Classification, Guid> _classificationRepository;
    private readonly IRepository<Tag, Guid> _categoryRepository;

    public PostAppService(
        IPostRepository postRepository,
        PostManager postManager,
        IRepository<Classification, Guid> classificationRepository,
        IRepository<Tag, Guid> categoryRepository
        )
    {
        _postRepository = postRepository;
        _postManager = postManager;
        _classificationRepository = classificationRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<PagedResultDto<PostDto>> GetListAsync(GetPostListDto input)
    {
        var posts = await _postRepository.GetListAsync(input.Sorting ?? nameof(Post.Sort), input.SkipCount, input.MaxResultCount);
        var totalCount = await _postRepository.CountAsync();

        return new PagedResultDto<PostDto>(totalCount, ObjectMapper.Map<List<PostWithDetails>, List<PostDto>>(posts));
    }

    public async Task<PostDto> GetAsync(Guid id)
    {
        var post = await _postRepository.GetAsync(id);

        return ObjectMapper.Map<PostWithDetails, PostDto>(post);
    }

    public async Task CreateAsync(CreatePostDto input)
    {
        await _postManager.CreateAsync(
             input.Title,
             input.ClassId,
             input.Author,
             input.Description ?? string.Empty,
             input.ContextValue,
             input.Picture ?? string.Empty,
             input.Sort,
             input.IsTop,
             input.PostsStatus,
             input.PostTagNames
        );
    }

    public async Task UpdateAsync(Guid id, UpdatePostDto input)
    {
        var post = await _postRepository.GetAsync(id, includeDetails: true);

        await _postManager.UpdateAsync(
            post,
             input.Title,
             input.ClassId,
             input.Author,
             input.Description ?? string.Empty,
             input.ContextValue,
             input.Picture ?? string.Empty,
             input.Sort,
             input.IsTop,
             input.PostsStatus,
             input.PostTagNames
        );
    }

    public async Task DeleteAsync(Guid id)
    {
        await _postRepository.DeleteAsync(id);
    }

    public async Task<ListResultDto<ClassificationDto>> GetClassificationAsync()
    {
        var classifications = await _classificationRepository.GetListAsync();

        return new ListResultDto<ClassificationDto>(
            ObjectMapper.Map<List<Classification>, List<ClassificationDto>>(classifications)
        );
    }

    public async Task<ListResultDto<TagDto>> GetTagsync()
    {
        var categories = await _categoryRepository.GetListAsync();

        return new ListResultDto<TagDto>(
            ObjectMapper.Map<List<Tag>, List<TagDto>>(categories)
        );
    }
}
