using FluentValidation;

namespace Barbearia.Application.Features.Customers.Commands.CreateCustomer;

public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty()
                .WithMessage("You should fill out a Name")
            .MaximumLength(50)
                .WithMessage("The {PropertyName} shouldn't have more than 50 characteres");

        RuleFor(c => c.Cpf)
            .NotEmpty()
                .WithMessage("You sould fill out a CPF")
            .Must(ValidateCPF) //Validação do Cpf.
                .When(c => c.Cpf != null, ApplyConditionTo.CurrentValidator)
                .WithMessage("The CPf should be valid number");

        RuleFor(c => c.BirthDate)
            .NotEmpty()
                .WithMessage("Person BirthDate cannot be empty");

        RuleFor(c => c.Email)
            .NotEmpty()
                .WithMessage("Person Email cannot be empty")
            .MaximumLength(80)
                .WithMessage("Person Email should have at most 80 characters")
            .EmailAddress()
                .WithMessage("Person Email should be a valid email address");

        RuleFor(c => c.Gender)
            .NotEmpty()
                .WithMessage("Person Gender cannot be empty");

        RuleFor(c => c.Telephones)
            .NotEmpty()
                .WithMessage("At least one telephone number is required")
            .Must(telephones => telephones.Count <= 1)
                .WithMessage("Only one telephone number is allowed");

        RuleForEach(c => c.Telephones)
            .ChildRules(telephone =>
            {
                telephone.RuleFor(t => t.Number)
                    .NotEmpty()
                        .WithMessage("Telephone number cannot be empty")
                    .MaximumLength(80)
                        .WithMessage("Telephone number should have at most 80 characters")
                    .Must(CheckNumber)
                        .WithMessage("Número de telefone inválido. Use o formato: 47988887777.");

                telephone.RuleFor(t => t.Type)
                    .NotEmpty()
                        .WithMessage("Telephone type is required");
            });

        RuleFor(c => c.Addresses)
            .Must(addresses => addresses.Count <= 1)
                .WithMessage("Only one address is allowed.");

        RuleForEach(c => c.Addresses)
            .ChildRules(address =>
            {
                address.RuleFor(a => a.Street)
                    .NotEmpty()
                        .WithMessage("Street cannot be empty")
                    .MaximumLength(80)
                        .WithMessage("Street should have at most 80 characters");

                address.RuleFor(a => a.Number)
                    .NotEmpty()
                        .WithMessage("Number cannot be empty");

                address.RuleFor(a => a.District)
                    .MaximumLength(60)
                        .WithMessage("District should have at most 60 characters");

                address.RuleFor(a => a.City)
                    .MaximumLength(60)
                        .WithMessage("City should have at most 60 characters");

                address.RuleFor(a => a.State)
                    .MaximumLength(2)
                        .WithMessage("State should have at most 2 characters");

                address.RuleFor(a => a.Cep)
                    .MaximumLength(8)
                        .WithMessage("CEP should have at most 8 characters");

                address.RuleFor(a => a.Complement)
                    .MaximumLength(80)
                        .WithMessage("Complement should have at most 80 characters");
            });

    }

    private bool ValidateCPF(string cpf) //Código de validação do CPF.
    {
        // Remove non-numeric characters
        cpf = cpf.Replace(".", "").Replace("-", "");

        // Check if it has 11 digits
        if (cpf.Length != 11)
        {
            return false;
        }

        // Check if all digits are the same
        bool allDigitsEqual = true;
        for (int i = 1; i < cpf.Length; i++)
        {
            if (cpf[i] != cpf[0])
            {
                allDigitsEqual = false;
                break;
            }
        }
        if (allDigitsEqual)
        {
            return false;
        }

        // Check first verification digit
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += int.Parse(cpf[i].ToString()) * (10 - i);
        }
        int remainder = sum % 11;
        int verificationDigit1 = remainder < 2 ? 0 : 11 - remainder;
        if (int.Parse(cpf[9].ToString()) != verificationDigit1)
        {
            return false;
        }

        // Check second verification digit
        sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += int.Parse(cpf[i].ToString()) * (11 - i);
        }
        remainder = sum % 11;
        int verificationDigit2 = remainder < 2 ? 0 : 11 - remainder;
        if (int.Parse(cpf[10].ToString()) != verificationDigit2)
        {
            return false;
        }

        return true;
    }

    public bool CheckNumber(string number)
    {
        if (!(number.Length == 11 && number.All(char.IsDigit)))
        {
            return false;
        }
        return true;
    }
}