using System.Text.Json;
using Barbearia.Application.Features.ProductsCollection;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Barbearia.Api.Controllers;

[ApiController]
[Route("api/productsCollection")]
public class ProductsCollectionController : MainController
{
    private readonly IMediator _mediator;

    public ProductsCollectionController(IMediator mediator){
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GetProductsCollectionDto>>> GetProductsCollection(string? searchQuery = "", int pageNumber = 1, int pageSize = 5)
    {
        var getProductsCollectionQuery = 
        new GetProductsCollectionQuery
        {
            SearchQuery = searchQuery,
            PageNumber = pageNumber,
            PageSize = pageSize
        };

        var requestResponse = await _mediator.Send(getProductsCollectionQuery);

        if(!requestResponse.IsSuccess) 
            return RequestValidationProblem(requestResponse, ModelState);

        var ProductsToReturn = requestResponse.Products;
        var paginationMetadata = requestResponse.PaginationMetadata;

        Response.Headers.Add("X-Pagination",JsonSerializer.Serialize(paginationMetadata));
        return Ok(ProductsToReturn);
    }
}