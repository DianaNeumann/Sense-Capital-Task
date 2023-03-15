using Infrastructure.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Presentation.Abstractions;
using Presentation.DAL;
using Presentation.Features;
using Presentation.Features.Events;
using Presentation.Features.Pictures;
using Presentation.Features.Spaces;

namespace Presentation.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddMediatR(typeof(IAssemblyMarker));
        collection.AddSingleton<IRepository<Event>, EventRepository>();
        collection.AddSingleton<IRepository<Picture>, PictureRepository>();
        collection.AddSingleton<IRepository<Space>, SpaceRepository>();
        
        
        return collection;
    }
}