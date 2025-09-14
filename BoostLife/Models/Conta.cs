namespace BoostLife.Models;

public class Conta
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public int Valor { get; set; }
    public int QtdParcelas { get; set; }
    public DateTime DiaCompra { get; set; }


     
}
