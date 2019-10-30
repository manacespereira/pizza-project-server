using System;
using PizzaProject.Domain.Core;

namespace PizzaProject.Domain.Queries.CustomizationQueries
{
    public class GetAllOrdersQuery : Query
    {

        public override void Validate()
        {
            // No caso de ter paginacao, podemos validar se a query esta correta aqui
            // ou no caso de buscar por ID, podemos validar ja se tem ID preenchido antes de ir buscar a entidade
        }
    }
}
