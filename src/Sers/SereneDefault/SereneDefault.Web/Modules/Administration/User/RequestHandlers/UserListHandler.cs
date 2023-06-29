using Serenity.Services;
using MyRequest = SereneDefault.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneDefault.Administration.UserRow>;
using MyRow = SereneDefault.Administration.UserRow;

namespace SereneDefault.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}