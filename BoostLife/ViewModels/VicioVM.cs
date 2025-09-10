using BoostLife.Models;
using BoostLife.Repositorys;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Threading;

namespace BoostLife.ViewModels;

internal partial class VicioVM : ObservableObject
{
    [ObservableProperty]
    private bool _cadOpen = false;

    private readonly ViciosRepository _rep;
    [ObservableProperty]
    private Vicio _currentVicio;

    [ObservableProperty]
    private ObservableCollection<Vicio> _vicios;

    private readonly DispatcherTimer _timer;

    public VicioVM()
    {
        _rep = new ViciosRepository();
        CurrentVicio = ResetarObj();
        Vicios = [];
        _timer = new();
        _timer.Interval = TimeSpan.FromSeconds(1);
        _timer.Tick += AtualizarProgressos;

        Load();
        
    }
    ~VicioVM()
    {
        _timer.Tick -= AtualizarProgressos;
    }
 

    public void Load()
    {
        PegarTodosOsVicios();
        IniciarTimers();
    }

    private void IniciarTimers()
    {
        if (!_timer.IsEnabled)
            _timer.Start();

    }


    private void AtualizarProgressos(object? sender, EventArgs e)
    {

        if (Vicios.Any())
        {
            var dataAtual = DateTime.Now;
            foreach(var v in Vicios)
            {
                TimeSpan dataSubtraida = dataAtual.Subtract(v.InicioJornada);
                int dataSubFormat = int.Parse(Math.Round(dataSubtraida.TotalDays).ToString() );
                if (dataSubFormat > 0)
                {
                    float result = (float)dataSubFormat / (float)v.DiasMeta;
                    float progress = result * 100.00f;
                    v.Progress = (int)Math.Round(progress) ;
                    
                    Console.WriteLine(progress);

                }
                else
                    v.Progress = 100;
            }
        }
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

        return new Vicio
        {
            Descricao = "",
            DiasMeta = 0,
            InicioJornada = DateTime.UtcNow,
            Id = 0
        };
    }






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

        Vicio vicio = new Vicio()
        {
            Descricao = CurrentVicio.Descricao,
            DiasMeta = CurrentVicio.DiasMeta,
            InicioJornada = DateTime.FromFileTimeUtc(CurrentVicio.InicioJornada.ToFileTimeUtc())

        };
        bool salvo = await _rep.Cadastrar(vicio);
        if (salvo)
            MessageBox.Show("O Vicio foi salvo");
        else
            MessageBox.Show("Erro ao salvar o vicio");

    }

}
