using NewRealEstate.DTO;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Service.Interface;

public interface IUserService
{
    public BaseResponse<UserDto> Create(UserRequestModel user);
}