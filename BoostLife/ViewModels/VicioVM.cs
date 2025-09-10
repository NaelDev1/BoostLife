using BoostLife.Models;
using BoostLife.Repositorys;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging.Abstractions;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;

namespace BoostLife.ViewModels;

internal partial class VicioVM : ObservableObject
{

    private readonly ViciosRepository _rep;
    [ObservableProperty]
    private Vicio _currentVicio;

    [ObservableProperty]
    private ObservableCollection<Vicio> _vicios;

    public VicioVM()
    {
        _rep = new ViciosRepository();
        CurrentVicio = ResetarObj();
        Vicios = [];
        Load();
    }

    public void Load()
    {

        PegarTodosOsVicios();

    }



    private async void PegarTodosOsVicios()
    {
        try
        {
            List<Vicio> vicios = await _rep.PegarTodos();
            Vicios ??= new([]);
            Vicios = new(vicios.AsEnumerable());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu uma falha em recuperar os vicios {ex.Message}"); 
        }
       

    }

    private static Vicio ResetarObj()
    {
       
        return  new Vicio
        {
            Descricao = "",
            DiasMeta= 0,
            InicioJornada = DateTime.UtcNow,
            Id= 0
        };
    }
        
 


    [ObservableProperty]
    private bool _cadOpen = true;

    [RelayCommand]
    private void OnCloseCadastro()
    {
        CadOpen = false;
    }

    [RelayCommand]
    private void OnOpenCadastro()
    {
        CadOpen = true;
       


    }

    [RelayCommand]
    private async Task SalvarVicio()
    {
        

        bool salvo = await _rep.Cadastrar(CurrentVicio);
        if (salvo)
            MessageBox.Show("O Vicio foi salvo");
        else
            MessageBox.Show("Erro ao salvar o vicio");

    }

}
