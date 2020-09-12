using System;

namespace EShop.Common.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
        Guid? UserId { get; set; }
    }
}