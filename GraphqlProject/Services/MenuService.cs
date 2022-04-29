using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphqlProject.Services
{
    public class MenuService : IMenu
    {
        private GraphQLDbContext _dbContext;

        public MenuService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Menu AddMenu(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenus()
        {
            return _dbContext.Menus.ToList();
        }
    }
}
