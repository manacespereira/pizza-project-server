using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace PizzaProject.Domain.Core
{
    public abstract class Query : Notifiable, IValidatable
    {
        public abstract void Validate();
    }
}
