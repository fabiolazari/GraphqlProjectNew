using GraphQL.Utilities;
using GraphqlProject.Mutation;
using GraphqlProject.Query;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GraphqlProject.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
