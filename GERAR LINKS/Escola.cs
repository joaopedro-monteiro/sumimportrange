namespace GERAR_LINKS
{
    public class Escola
    {
        public string? Nome { get; set; }
        public string? ImportRange(int celula)
        {
            return $"'{Nome}'!E{celula}";
        }
    }
}
