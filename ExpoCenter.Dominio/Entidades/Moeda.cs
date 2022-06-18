namespace ExpoCenter.Dominio.Entidades
{
    public class Moeda
    {
        private const string nota = "nota(s)";
        private const string moeda = "moeda(s)";

        public Moeda()
        {
            CarregarValores();
        }

        public Dictionary<decimal, string> Valores { get; set; } = new Dictionary<decimal, string>();

        private void CarregarValores()
        {
            Valores.Add(200, nota);
            Valores.Add(100, nota);
            Valores.Add(50, nota);
            Valores.Add(20, nota);
            Valores.Add(10, nota);
            Valores.Add(5, nota);
            Valores.Add(2, nota);
            Valores.Add(1, moeda);
            Valores.Add(0.5m, moeda);
            Valores.Add(0.25m, moeda);
            Valores.Add(0.1m, moeda);
            Valores.Add(0.05m, moeda);
            Valores.Add(0.01m, moeda);
        }
    }
}