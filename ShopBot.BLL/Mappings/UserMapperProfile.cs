using AutoMapper;
using ShopBot.Core.Dtos;
using ShopBot.Core.InputModels;
using ShopBot.Core.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.BLL.Mappings
{
	public class UserMapperProfile : Profile
	{
		public UserMapperProfile()
		{
			CreateMap<UserInputModel, UserDto>();
			CreateMap<UserDto, UserOutputModel>();
			


			//.ForMember(dest => dest.Orders, opt => opt.MapFrom(src => src.Orders));
		}
	}
}