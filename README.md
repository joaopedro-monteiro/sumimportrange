<!DOCTYPE html>
<html>
<head>
  <title>Automação de Cálculos - Materiais de Limpeza</title>
</head>
<body>
  <h1>Automação de Cálculos de Materiais de Limpeza para Escolas e Creches</h1>
  <p>Quando trabalhava na Secretaria de Educação de minha cidade, uma das responsabilidades do meu setor consistia em coordenar a entrega mensal de materiais de limpeza para as escolas e creches municipais. Para cada estabelecimento de ensino, era necessário criar um arquivo denominado 'Guia de Remessa', contendo informações da instituição, um campo destinado à assinatura do responsável pelo recebimento dos produtos e uma tabela detalhando os itens e suas respectivas quantidades. As quantidades solicitadas eram registradas por cada diretora em uma planilha do Google Sheets dedicada a esse propósito. Uma imagem exemplificativa dessa planilha pode ser visualizada <a href="https://prnt.sc/0PdbFk9sF2Nz" target="_blank"> aqui </a>.

Até esse ponto, o processo transcorria sem maiores dificuldades. Eu disponibilizava o link da planilha para as diretoras, que então preenchiam as quantidades na aba correspondente à sua escola. Em seguida, eu gerava os PDFs, imprimia-os e providenciava a entrega aos responsáveis pela distribuição nas escolas. No entanto, como também era incumbido de efetuar as compras dos materiais, surgia um desafio adicional: calcular a quantidade total gasta em todas as escolas e creches. Para tal, era necessário somar cada item de limpeza de todas as instituições.

Numa abordagem simplificada, eu poderia criar uma nova aba intitulada 'TOTAIS', e manualmente realizar a soma de cada item e escola. No entanto, isso seria uma tarefa árdua e demorada. Nesse contexto, ocorreu-me a ideia de automatizar o processo utilizando a função de soma do Google Sheets. Mas, para minha surpresa, isso também se revelaria trabalhoso. Nesse momento, recordei-me da possibilidade de automatizar o processo de criação da fórmula, em vez de fazê-lo manualmente. A solução seria desenvolver um código em C# que realizasse essa tarefa. Optei por criar um código que fosse funcional e abordável, sem a necessidade de frameworks ou soluções complexas.

Segue abaixo uma descrição ilustrativa desse processo:.</p>

  <h2>Funcionalidades</h2>
  <ul>
    <li>Criação de arquivos 'Guia de Remessa' com informações de cada instituição.</li>
    <li>Registro das quantidades de materiais de limpeza em uma planilha Google Sheets.</li>
    <li>Automatização dos cálculos de quantidades totais utilizando C#.</li>
  </ul>

  <h2>Visualizações</h2>
  <h3>Arquivo TXT com Fórmulas de Soma Prontas</h3>
  <a href="https://prnt.sc/8ZGQG-g-rVQ5">Arquivo TXT com Fórmulas de Soma Prontas</a>

  <h3>Resultado da Automação</h3>
  <a href="https://prnt.sc/oOTHQ0LS0ptf"> Resultado da Automação</a>

  <h2>Planilha Original</h2>
  <p>Para visualizar a planilha original, acesse o link:</p>
  <a href="https://docs.google.com/spreadsheets/d/1oowqsa0Hpv1pko2kzD8ID3DAaDpbEMcfp0NQ0m2RM8U/edit?usp=sharing">Planilha no Google Sheets</a>
</body>
</html>
