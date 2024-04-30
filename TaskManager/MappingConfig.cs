using AutoMapper;
using TaskManager.Model;
using TaskManager.Model.DTO;

namespace TaskManager
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<MyTask, MyTaskDTO>().ReverseMap();
			CreateMap<MyTask, MyTaskCreateDTO>().ReverseMap();
			CreateMap<MyTask, MyTaskUpdateDoneDTO>().ReverseMap();
			CreateMap<MyTask, MyTaskUpdateOrderDTO>().ReverseMap();
		}
    }
}
