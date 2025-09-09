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
}