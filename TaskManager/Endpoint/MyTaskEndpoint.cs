using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Net;
using TaskManager.Model;
using TaskManager.Model.DTO;
using TaskManager.Repository.IRepository;

namespace TaskManager.Endpoint
{
	public static class MyTaskEndpoint
	{
		public static void ConfigureMyTaskEndpoints(this WebApplication app)
		{

			app.MapGet("/api/myTask", GetAllMyTask)
				.WithName("GetAll").Produces<APIResponse>(200);

			app.MapGet("/api/myTask/{id:int}", GetMyTask)
				.WithName("Get").Produces<APIResponse>(200);

			app.MapPost("/api/myTask", CreateMyTask)
				.WithName("Create")
				.Accepts<MyTaskCreateDTO>("application/json")
				.Produces<APIResponse>(201)
				.Produces(400);

			app.MapPut("/api/myTask/markAsDone", MarkAsDoneMyTask)
				.WithName("MarkAsDone")
				.Accepts<MyTaskUpdateDoneDTO>("application/json")
				.Produces<APIResponse>(200)
				.Produces(400);

			app.MapPut("/api/myTask/order", OrderMyTask)
				.WithName("Reorder")
				.Accepts<MyTaskUpdateOrderDTO>("application/json")
				.Produces<APIResponse>(200)
				.Produces(400);

			app.MapDelete("/api/myTask/{id:int}", DeleteMyTask);
		}

		private async static Task<IResult> GetMyTask(IMyTaskRepository _myTaskRepo, IMemoryCache _cache, int id)
		{
			_cache.CreateEntry("Endpoint executed.");
			APIResponse response = new();
			response.Result = await _myTaskRepo.GetAsync(id);
			response.IsSuccess = true;
			response.StatusCode = HttpStatusCode.OK;
			return Results.Ok(response);
		}

		private async static Task<IResult> CreateMyTask(IMyTaskRepository _myTaskRepo, IMapper _mapper,
				 [FromBody] MyTaskCreateDTO myTask_C_DTO)
		{
			APIResponse response = new() { IsSuccess = false, StatusCode = HttpStatusCode.BadRequest };

			if (_myTaskRepo.GetAsync(myTask_C_DTO.Description).GetAwaiter().GetResult() != null)
			{
				response.ErrorMessages.Add("MyTask Description already Exists");
				return Results.BadRequest(response);
			}

			MyTask myTask = _mapper.Map<MyTask>(myTask_C_DTO);

			await _myTaskRepo.CreateAsync(myTask);
			await _myTaskRepo.SaveAsync();
			MyTaskCreateDTO myTaskDTO = _mapper.Map<MyTaskCreateDTO>(myTask);

			response.Result = myTaskDTO;
			response.IsSuccess = true;
			response.StatusCode = HttpStatusCode.Created;
			return Results.Ok(response);
		}

		private async static Task<IResult> MarkAsDoneMyTask(IMyTaskRepository _myTaskRepo, IMapper _mapper,
				 [FromBody] MyTaskUpdateDoneDTO myTask_U_DTO)
		{
			APIResponse response = new() { IsSuccess = false, StatusCode = HttpStatusCode.BadRequest };

			await _myTaskRepo.UpdateAsync(_mapper.Map<MyTask>(myTask_U_DTO));
			await _myTaskRepo.SaveAsync();

			response.Result = _mapper.Map<MyTaskUpdateDoneDTO>(await _myTaskRepo.GetAsync(myTask_U_DTO.Id)); ;
			response.IsSuccess = true;
			response.StatusCode = HttpStatusCode.OK;
			return Results.Ok(response);
		}

		private async static Task<IResult> OrderMyTask(IMyTaskRepository _myTaskRepo, IMapper _mapper,
		 [FromBody] MyTaskUpdateOrderDTO myTask_U_DTO)
		{
			APIResponse response = new() { IsSuccess = false, StatusCode = HttpStatusCode.BadRequest };

			await _myTaskRepo.UpdateAsync(_mapper.Map<MyTask>(myTask_U_DTO));
			await _myTaskRepo.SaveAsync();

			response.Result = _mapper.Map<MyTaskUpdateOrderDTO>(await _myTaskRepo.GetAsync(myTask_U_DTO.Id)); ;
			response.IsSuccess = true;
			response.StatusCode = HttpStatusCode.OK;
			return Results.Ok(response);
		}

		private async static Task<IResult> DeleteMyTask(IMyTaskRepository _myTaskRepo, int id)
		{
			APIResponse response = new() { IsSuccess = false, StatusCode = HttpStatusCode.BadRequest };

			MyTask myTaskFromStore = await _myTaskRepo.GetAsync(id);
			if (myTaskFromStore != null)
			{
				await _myTaskRepo.RemoveAsync(myTaskFromStore);
				await _myTaskRepo.SaveAsync();
				response.IsSuccess = true;
				response.StatusCode = HttpStatusCode.NoContent;
				return Results.Ok(response);
			}
			else
			{
				response.ErrorMessages.Add("Invalid Id");
				return Results.BadRequest(response);
			}
		}

		private async static Task<IResult> GetAllMyTask(IMyTaskRepository _myTaskRepo, IMemoryCache _cache)
		{
			APIResponse response = new();
			_cache.CreateEntry("Getting all MyTasks");

			IEnumerable<MyTask> myTasks = await _myTaskRepo.GetAllAsync();
			response.Result = myTasks.OrderBy(u => u.Order);
			response.IsSuccess = true;
			response.StatusCode = HttpStatusCode.OK;
			return Results.Ok(response);
		}
	}
}
