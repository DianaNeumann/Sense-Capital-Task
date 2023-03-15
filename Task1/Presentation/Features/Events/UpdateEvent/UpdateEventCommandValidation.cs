using FluentValidation;
using Presentation.Abstractions;
using Presentation.Features.Pictures;
using Presentation.Features.Spaces;

namespace Presentation.Features.Events.UpdateEvent;

public class UpdateEventCommandValidation : AbstractValidator<UpdateEvent.Command>
{
    public UpdateEventCommandValidation(
        IRepository<Picture> puctureRepository,
        IRepository<Space> spaceRepository,
        IRepository<Event> eventRepository)
    {
        RuleFor(x => eventRepository.FindById(x.Id)).NotNull();
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => DateTime.Compare(x.Start, x.End)).LessThan(0);
        RuleFor(x => puctureRepository.FindById(x.Picture)).NotNull();
        RuleFor(x => spaceRepository.FindById(x.Space)).NotNull();

    }
}