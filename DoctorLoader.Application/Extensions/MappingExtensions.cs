using AutoMapper;
using AutoMapper.QueryableExtensions;
using DoctorLoader.Application.Contracts.DTOs;
using DoctorLoader.Application.Contracts.DTOs.Base;
using DoctorLoader.Domain;
using Microsoft.EntityFrameworkCore;

namespace DoctorLoader.Application.Extensions
{
    internal static class MappingExtensions
    {
        public static Task<PaginatedList<TDestination>> PaginatedListAsync<TDestination>(
            this IQueryable<TDestination> queryable, int pageNumber, int pageSize) where TDestination : BaseDto
        => PaginatedList<TDestination>.CreateAsync(queryable, pageNumber, pageSize);

        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(
            this IQueryable queryable, IConfigurationProvider configuration) where TDestination : BaseEntity
            => queryable.ProjectTo<TDestination>(configuration).ToListAsync();
    }
}
