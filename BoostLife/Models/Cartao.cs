using CommunityToolkit.Mvvm.ComponentModel;

namespace BoostLife.Models;

public partial class Cartao  : ObservableObject
{

    [ObservableProperty]
    private int _id;

    [ObservableProperty]
    private string _titulo = string.Empty;

    [ObservableProperty]
    private decimal _faturaMes;



}
