using BoostLife.DAL;
using BoostLife.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
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
        try
        {
            await _context.AddAsync(obj);
            return await _context.SaveChangesAsync() > 0;
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public async Task<List<Vicio>> PegarTodos() => await _context.Vicios.ToListAsync();

    


    }
