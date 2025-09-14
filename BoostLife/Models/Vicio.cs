using CommunityToolkit.Mvvm.ComponentModel;

namespace BoostLife.Models;

public partial class Vicio : ObservableObject
{
    [ObservableProperty]
    private int _id;
    [ObservableProperty]
    private string _descricao = string.Empty;
    [ObservableProperty]
    private DateTime _inicioJornada;

   
    [ObservableProperty]
    private int _diasMeta;

    [ObservableProperty]
    private int _progress;

    [ObservableProperty]
    private double _tempoPassado;


}
