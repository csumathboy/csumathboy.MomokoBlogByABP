
using AutoMapper.Internal.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace csumathboy.MomokoBlog.Classifications;
 
public class ClassificationAppService : MomokoBlogAppService, IClassificationAppService
{
    private readonly IRepository<Classification, Guid> _classificationRepository;
    public ClassificationAppService(
       IRepository<Classification, Guid> classificationRepository)
    {
        _classificationRepository = classificationRepository;
    }
    public async Task<PagedResultDto<ClassificationDto>> GetListAsync(GetClassificationListDto input)
    {
        var classifications = await _classificationRepository.GetPagedListAsync(input.SkipCount,input.MaxResultCount, input.Sorting ?? nameof(Classification.Name));
        var count = await _classificationRepository.GetCountAsync();
        return new PagedResultDto<ClassificationDto>(
            count,
            ObjectMapper.Map<List<Classification>, List<ClassificationDto>>(classifications)
        );
    }

    public async Task<ClassificationDto> CreateAsync(CreateClassificationDto input)
    {
        var result= await _classificationRepository.InsertAsync(
            ObjectMapper.Map<CreateClassificationDto, Classification>(input)
        );
        return ObjectMapper.Map<Classification, ClassificationDto>(result);
    }
 
    public async Task<ClassificationDto> GetAsync(Guid id)
    {
        return ObjectMapper.Map<Classification, ClassificationDto>(
            await _classificationRepository.GetAsync(id)
        );
    }

    public async Task UpdateAsync(Guid id, UpdateClassificationDto input)
    {
        var classification = await _classificationRepository.GetAsync(id);
        ObjectMapper.Map(input, classification);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _classificationRepository.DeleteAsync(id);
    }
}

