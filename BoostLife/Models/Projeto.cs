using CommunityToolkit.Mvvm.ComponentModel;

namespace BoostLife.Models;

public partial class Projeto : ObservableObject
{
    [ObservableProperty]
    private int _id;
    [ObservableProperty]
    private string _nomeProjeto = string.Empty;
    [ObservableProperty]
    private DateTime _dataLancamento;
    [ObservableProperty]
    private DateTime _previsaoTermino;
    [ObservableProperty]
    private int _tempoTrabalhado;
    [ObservableProperty]
    private TimeSpan _totalHorasTrabalhadas;
    [ObservableProperty]
    private bool _isWorking;
    [ObservableProperty]
    private string _hexCardColor = "#404040";
    [ObservableProperty]
    private string _hexTextColor = "#fff";








}