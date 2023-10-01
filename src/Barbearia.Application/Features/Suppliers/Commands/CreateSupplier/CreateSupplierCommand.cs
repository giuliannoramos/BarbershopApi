
using Barbearia.Application.Models;
using MediatR;

namespace Barbearia.Application.Features.Suppliers.Commands.CreateSupplier;

public class CreateSupplierCommand : IRequest<CreateSupplierCommandResponse>
{
    public string Name{get;set;} = string.Empty;
    public DateOnly BirthDate{get;set;}
    public int Gender { get; set; }
    public string Cpf { get; set; } = string.Empty;
    public string Cnpj {get;set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public List<AddressDto> Addresses {get; set;} = new();
    public List<TelephoneDto> Telephones {get; set;} = new();
}