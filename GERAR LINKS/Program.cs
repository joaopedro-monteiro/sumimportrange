StreamWriter sw = new StreamWriter(@"C:\Users\João Pedro\Documents\in.txt");
string nome;
string link;
int celula = 12;

for (int j = 0; j < 33; j++)
{
    sw.Write("=SUM(");

    for (int i = 0; i < 16; i++)
    {
        

        if (i == 0)
        {
            nome = "DONA DUCA";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=1847449115";
        }

        else if (i == 1)
        {
            nome = "JOÃO DORNAS";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=0";
        }

        else if (i == 2)
        {
            nome = "PRAXEDES";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=1754393755";
        }

        else if (i == 3)
        {
            nome = "FLÁVIO";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=1288315996";
        }

        else if (i == 4)
        {
            nome = "VIRGÍLIO";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=1514439084";
        }

        else if (i == 5)
        {
            nome = "DONA JOESSE";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=759992890";
        }

        else if (i == 6)
        {
            nome = "VALDIRA";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=1414940029";
        }

        else if (i == 7)
        {
            nome = "JACINTO";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=1514910454";
        }

        else if (i == 8)
        {
            nome = "DONA ZULMA";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=1475348979";
        }

        else if (i == 9)
        {
            nome = "SÃO VICENTE";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=950352698";
        }

        else if (i == 10)
        {
            nome = "ELVINO PAIVA";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=220916141";
        }

        else if (i == 11)
        {
            nome = "D LIQUINHA";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=1006054579";
        }

        else if (i == 12)
        {
            nome = "DR HUGO";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=622061853";
        }

        else if (i == 13)
        {
            nome = "D ÍRIS";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=553353532";
        }

        else if (i == 14)
        {
            nome = "AUXILIADORA";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=490683230";
        }

        else if (i == 15)
        {
            nome = "ERAÍDA";
            link = "https://docs.google.com/spreadsheets/d/1_hCbjnaw7O_ys51zJ9XKM-HnusQSb0W-qkLGKdAiHcs/edit#gid=139294299";
        }
        else continue;

        sw.Write("IMPORTRANGE(\"" + link + "\";" + "\"" + nome + "!E" + celula + ":F" + celula + "\")");

        if (i != 15)
        {
            sw.Write(" + ");
        }
    }

    celula++;

    sw.Write(")\n\n");
}

sw.Close();