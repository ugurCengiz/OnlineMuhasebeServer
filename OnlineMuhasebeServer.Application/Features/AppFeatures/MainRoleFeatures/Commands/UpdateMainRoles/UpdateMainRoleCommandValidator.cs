using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRoles
{
    public sealed class UpdateMainRoleCommandValidator : AbstractValidator<UpdateMainRolesCommand>
    {
        public UpdateMainRoleCommandValidator()
        {
            RuleFor(p => p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
            RuleFor(p => p.Title).NotEmpty().WithMessage("Başlık alanı boş olamaz!");
            RuleFor(p => p.Title).NotNull().WithMessage("Başlık alanı boş olamaz!");
        }
    }
}
