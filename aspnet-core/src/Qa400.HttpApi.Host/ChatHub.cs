using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.Users;

namespace Qa400
{
    [Authorize]
    public class ChatHub : AbpHub
    {
        private readonly ICurrentUser _currentUser;

        public ChatHub(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
