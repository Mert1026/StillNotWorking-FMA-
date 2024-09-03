using DbContext;
using Models;


namespace FinanceManagementApp.Server.Controllers
{
    public class ControllerForHelpWithAggregation
    {
        FMADbContext dbContext = new FMADbContext();

        public Users GetUserByID(string id)
        {
            if (dbContext.Users.Contains(dbContext.Users.FirstOrDefault(u => u.Id == id)))
            {
                return dbContext.Users.FirstOrDefault(u => u.Id == id);
            }
            else
            {
                throw new ArgumentException($"There is no such user!(GetUserBy({id}))");
            }
        }

        public Users GetUserByName(string name)
        {
            if (dbContext.Users.Contains(dbContext.Users.FirstOrDefault(u => u.Name == name)))
            {
                return dbContext.Users.FirstOrDefault(u => u.Name == name);
            }
            else
            {
                throw new ArgumentException($"There is no such user!(GetUserName({name}))");
            }
        }

   

       //TO DO...
    }
}
