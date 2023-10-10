using AutoMapper;
using Barbearia.Application.Features.Orders.Commands.CreateOrder;
using Barbearia.Application.Features.Orders.Commands.UpdateOrder;
using Barbearia.Application.Features.Orders.Queries.GetAllOrders;
using Barbearia.Application.Features.Orders.Queries.GetOrderById;
using Barbearia.Application.Features.Orders.Queries.GetOrderByNumber;
using Barbearia.Application.Features.OrdersCollection;
using Barbearia.Application.Models;
using Barbearia.Domain.Entities;

namespace Barbearia.Application.Profiles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<UpdateOrderCommand, Order>();
        CreateMap<Order, UpdateOrderDto>();

        CreateMap<Order, GetOrdersCollectionDto>();
        CreateMap<Order, GetAllOrdersDto>();
        CreateMap<Order, GetOrderByIdDto>();
        CreateMap<Order, GetOrderByNumberDto>();

        CreateMap<CreateOrderCommand, Order>();
        CreateMap<Order, CreateOrderDto>();

        CreateMap<PersonDto, Person>().ReverseMap();
        CreateMap<PaymentDto, Payment>().ReverseMap();
    }
}