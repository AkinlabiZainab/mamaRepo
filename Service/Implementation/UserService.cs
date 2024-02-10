using NewRealEstate.DTO;
using NewRealEstate.Models.Entities;
using NewRealEstate.Models.Enum;
using NewRealEstate.Repository.Implementation;
using NewRealEstate.Service.Interface;

namespace NewRealEstate.Service.Implementation;

public class UserService : IUserService
{
    private readonly UserRepository _user;
    private readonly AddressRepository _address;
    private readonly ProfileRepository _profile;
    public UserService(UserRepository user, AddressRepository address, ProfileRepository profile)
    {
        _user = user;
        _address = address;
        _profile = profile;
    }
    public BaseResponse<UserDto> Create(UserRequestModel user)
    {
       var CheckUser =  _user.Exists(a => a.Email == user.Email);
       if (CheckUser)
       {
           return new BaseResponse<UserDto>()
           {
               Message = "email present, ",
               Status = false,

           };
       }
       else
       {
           var newUser = new User
           {
               DateCreated = DateTime.Now,
               Email = user.Email,
               Password = user.Password,
               UserName = user.UserName,

           };
           _user.Create(newUser);
          
           var newAddress = new Address
           {

               DateCreated = DateTime.Now,
               Number = user.Profile.Address.Number,
               Street = user.Profile.Address.Street,
               LgArea = user.Profile.Address.LgArea,
               State = user.Profile.Address.State
           };
           _address.Create(newAddress);
           
           

           var newProfile = new Profile
           {
               
               DateCreated = DateTime.Now,
               IsDeleted = false,
               FirstName = user.Profile.FirstName,
               LastName = user.Profile.LastName,
               PhoneNumber = user.Profile.PhoneNumber,
               Age = user.Profile.Age,
               Sex = (Gender)0,
               AddressId = newAddress.Id,
               Address = newAddress,
               UserId = newUser.Id,
               User = newUser,
           };
           _profile.Create(newProfile);
           _user.Save();
            
           return new BaseResponse<UserDto>()
           {
               Message = "email not found ",
               Status = true,
               Data = new UserDto
               {
                   Id = newUser.Id,
                   Password = newUser.Password,
                   Email = newUser.Email,
                   UserName = newUser.UserName,
                   FirstName = newProfile.FirstName,
                   LastName = newProfile.LastName,
                   PhoneNumber = newProfile.PhoneNumber,
                   Age = newProfile.Age,
                   Sex = newProfile.Sex,
                   Number = newAddress.Number,
                   Street = newAddress.Street,
                   LgArea = newAddress.LgArea,
                   State = newAddress.State,
                   RoleName = ,
                   RoleDescription = null
               }

           };
       }
       
    }
    
}