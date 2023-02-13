﻿using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;

public sealed class CreateUCAFCommandValidator : AbstractValidator<CreateUCAFCommand>
{
    public CreateUCAFCommandValidator()
    {
        RuleFor(p => p.Code).NotEmpty().WithMessage("Hesap planı kodu boş olamaz!");
        RuleFor(p => p.Code).NotNull().WithMessage("Hesap planı kodu boş olamaz!");
        RuleFor(p => p.Code).MinimumLength(5).WithMessage("Hesap planı kodu en az 5 karakter olmalıdır!");
        RuleFor(p => p.Name).NotEmpty().WithMessage("Hesap planı adı boş olamaz!");
        RuleFor(p => p.Name).NotNull().WithMessage("Hesap planı adı boş olamaz!");
        RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket bilgisi adı boş olamaz!");
        RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket bilgisi adı boş olamaz!");
        RuleFor(p => p.Type).NotNull().WithMessage("Hesap planı tipi boş olamaz!");
        RuleFor(p => p.Type).NotEmpty().WithMessage("Hesap planı tipi boş olamaz!");
      
    }
}