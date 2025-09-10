using BoostLife.DAL;
using BoostLife.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BoostLife.Repositorys;

public class ViciosRepository : RepositoryBase
{

    private readonly BoostLifeContext _context;
    public ViciosRepository()
    {
        _context = GetContext();
        
    }


    public async Task<bool> Cadastrar(Vicio obj)
    {
        await _context.AddAsync(obj);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<List<Vicio>> PegarTodos() => await _context.Vicios.ToListAsync();

    


    }
