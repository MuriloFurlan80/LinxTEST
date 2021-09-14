Plataforma para venda online: 

# Cria��o de um site que apresente uma listagem de produtos, com foto (50px X 50px), Nome (50 caracteres) pre�o de venda e descritivo b�sico (200 caracteres). 
A partir desta lista deve ser poss�vel o usu�rio colocar produtos em uma cesta de compras. O usu�rio dever� poder informar a quantidade de itens 
para cada produto na cesta. A medida que as quantidades s�o alteradas o valor total de cada produto, bem como o total da compra devem ser recalculados. 
O pre�o de venda (PrecoVendaProdutoX) dos produtos dever� ser calculado pelo sistema de acordo com as seguintes regras: 

# Cada produto dever� ter associado a ele o seu custo de compra (CustoCompra), caso o custo de compra n�o for informado o produto 
n�o dever� aparecer na listagem; 

# O usu�rio dever� informar um valor para as despesas totais (DespesasTotais) da loja e estas despesas dever�o ser rateadas igualmente entre os produtos 
(RateioDespesas), independentemente do valor destes. Caso o valor das despesas n�o seja informado o valor R$ 400,00 dever� ser assumido como padr�o; 

# Opcionalmente o usu�rio poder� informa um percentual para margem de lucro (%MargemLucro). Este valor, se existir, dever� ser aplicado 
para encontrar o pre�o de venda de cada produto; 

# Todos os valores devem ser superiores a zero, exceto a margem de lucro que poder� ser maior ou igual a zero.