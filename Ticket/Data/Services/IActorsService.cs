using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ticket.Data.Base;
using Ticket.Models;

namespace Ticket.Data.Services
{
    public interface IActorsService: IEntityBaseRepository<Actor>
    {

        //Task<IEnumerable<Actor>> GetAllAsync();
       
        //Task<Actor> GetByIdAsync(int id);
        //Task AddAsync(Actor actor);
        //Task<Actor> UpdateAsync(int id, Actor newActor);

        //Task  DeleteAsync(int id);
    }
}
