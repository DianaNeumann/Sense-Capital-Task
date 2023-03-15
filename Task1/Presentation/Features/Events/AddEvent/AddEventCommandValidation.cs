using FluentValidation;

namespace Presentation.Features.Events.AddEvent;

public class AddEventCommandValidation : AbstractValidator<AddEvent.Command>
{
    public AddEventCommandValidation()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => DateTime.Compare(x.Start, x.End)).LessThan(0);
    }
}