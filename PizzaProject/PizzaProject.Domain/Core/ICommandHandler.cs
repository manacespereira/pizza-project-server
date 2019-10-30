using System;
namespace PizzaProject.Domain.Core
{
    public interface ICommandHandler<C, R> where C : Command where R : class
    {
        R Handle(C command);
    }
}
