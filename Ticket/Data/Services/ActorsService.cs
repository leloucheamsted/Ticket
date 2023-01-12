using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket.Data.Base;
using Ticket.Models;

namespace Ticket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
        //    private readonly AppDbContext _context;

        //    public ActorsService(AppDbContext context)
        //    {
        //        _context = context;
        //    }
        //    public async Task AddAsync(Actor actor)
        //    {
        //        await _context.Actors.AddAsync(actor);
        //        await _context.SaveChangesAsync();
        //    }

        //    public async Task DeleteAsync(int id)
        //    {
        //        var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        //         _context.Actors.Remove(result);
        //        await _context.SaveChangesAsync();
        //    }



        //    public async Task<Actor> UpdateAsync(int id, Actor newActor)
        //    {
        //        _context.Update(newActor);
        //        await _context.SaveChangesAsync();
        //        return newActor;
        //    }
        //}
   // }
