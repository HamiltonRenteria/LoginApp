using Application.Commons.Bases;
using Application.DTOs.User;

namespace Application.Interfaces
{
    public interface IUserApplication
    {
        Task<BaseResponse<bool>> RegisterUser(UserRequestDto requestDto);
        Task<BaseResponse<string>> GenerateToken(TokenRequestDto requestDto);
    }
}
