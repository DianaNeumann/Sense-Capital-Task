using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Presentation.Abstractions;
using Presentation.Features.Events;
using Presentation.Features.Pictures;
using Presentation.Features.Spaces;
using Presentation.Repositories;

namespace Presentation.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddMediatR(typeof(IAssemblyMarker));
        collection.AddSingleton<IRepository<Event>, EventRepository>();
        collection.AddSingleton<IRepository<Picture>, PictureRepository>();
        collection.AddSingleton<IRepository<Space>, SpaceRepository>();
        collection.AddValidatorsFromAssemblyContaining<IAssemblyMarker>();
        return collection;
    }
}