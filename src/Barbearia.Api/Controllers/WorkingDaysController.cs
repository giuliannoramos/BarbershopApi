using Barbearia.Application.Features.WorkingDays.Commands.CreateWorkingDay;
using Barbearia.Application.Features.WorkingDays.Commands.DeleteWorkingDay;
using Barbearia.Application.Features.WorkingDays.Commands.UpdateWorkingDay;
using Barbearia.Application.Features.WorkingDays.Query.GetWorkingDay;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Barbearia.Api.Controllers;

[ApiController]
[Route("api/employees/{employeeId}/workingdays")]
public class WorkingDaysController : MainController
{
    private readonly IMediator _mediator;

    public WorkingDaysController(IMediator mediator){
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpGet(Name = "GetWorkingDays")]
    public async Task<ActionResult<IEnumerable<GetWorkingDayDto>>> GetWorkingDay(int employeeId)
    {
        var getWorkingDayQuery = new GetWorkingDayQuery{PersonId = employeeId};
        var workingDayToReturn = await _mediator.Send(getWorkingDayQuery);

        if(workingDayToReturn == null) return NotFound();

        return Ok(workingDayToReturn);
    }

    [HttpPost]
    public async Task<ActionResult<CreateWorkingDayCommandResponse>> CreateWorkingDay(int employeeId, CreateWorkingDayCommand createWorkingDayCommand)
    {
        if(employeeId != createWorkingDayCommand.PersonId) return BadRequest();

        var createWorkingDayCommandResponse = await _mediator.Send(createWorkingDayCommand); 

        if(!createWorkingDayCommandResponse.IsSuccess){
            return HandleRequestError(createWorkingDayCommandResponse);
        }

        var workingDayToReturn = createWorkingDayCommandResponse.WorkingDay;

        return CreatedAtRoute(
            "GetWorkingDays",
            new{
                employeeId
            }, workingDayToReturn
            
        );
    }

    [HttpPut ("{workingdayId}")]
    public async Task<ActionResult> UpdateWorkingDay(int workingdayId, int employeeId, UpdateWorkingDayCommand updateWorkingDayCommand)
    {
        if(employeeId != updateWorkingDayCommand.PersonId) return BadRequest();

        if(workingdayId != updateWorkingDayCommand.WorkingDayId) return BadRequest();
        var updateWorkingDayCommandResponse = await _mediator.Send(updateWorkingDayCommand);

        if(!updateWorkingDayCommandResponse.IsSuccess){
            return HandleRequestError(updateWorkingDayCommandResponse);
        }
        return NoContent();

    }

    [HttpDelete ("{workingdayId}")]
    public async Task<ActionResult> DeleteWorkingDay(int employeeId, int workingDayId)
    {
        var deleteWorkingDayCommand = new DeleteWorkingDayCommand{PersonId = employeeId, WorkingDayId = workingDayId};
        var result = await _mediator.Send(deleteWorkingDayCommand);

        if(!result) return NotFound();
        
        return NoContent();
    }
}