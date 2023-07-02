using GERAR_LINKS;
using System.Text;

var escolas = new List<Escola>()
{
    new Escola() { Nome = "DONA DUCA" },
    new Escola() { Nome = "JOÃO DORNAS" },
    new Escola() { Nome = "PRAXEDES" },
    new Escola() { Nome = "FLÁVIO" },
    new Escola() { Nome = "VIRGÍLIO" },
    new Escola() { Nome = "DONA JOESSE" },
    new Escola() { Nome = "VALDIRA" },
    new Escola() { Nome = "JACINTO" },
    new Escola() { Nome = "DONA ZULMA" },
    new Escola() { Nome = "SÃO VICENTE" },
    new Escola() { Nome = "ELVINO PAIVA" },
    new Escola() { Nome = "D LIQUINHA" },
    new Escola() { Nome = "DR HUGO" },
    new Escola() { Nome = "D ÍRIS" },
    new Escola() { Nome = "AUXILIADORA" },
    new Escola() { Nome = "ERAÍDA" },
};

var stringBuilder = new StringBuilder();

for (int i = 0, celula = 12; i < 33; i++, celula++)
    stringBuilder.AppendLine($"={string.Join('+', escolas.Select(escola => escola.ImportRange(celula)))}");

File.WriteAllText(@"C:\Users\João Pedro\Documents\in.txt", stringBuilder.ToString());