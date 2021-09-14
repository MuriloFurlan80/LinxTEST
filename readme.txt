Plataforma para venda online: 

# Criação de um site que apresente uma listagem de produtos, com foto (50px X 50px), Nome (50 caracteres) preço de venda e descritivo básico (200 caracteres). 
A partir desta lista deve ser possível o usuário colocar produtos em uma cesta de compras. O usuário deverá poder informar a quantidade de itens 
para cada produto na cesta. A medida que as quantidades são alteradas o valor total de cada produto, bem como o total da compra devem ser recalculados. 
O preço de venda (PrecoVendaProdutoX) dos produtos deverá ser calculado pelo sistema de acordo com as seguintes regras: 

# Cada produto deverá ter associado a ele o seu custo de compra (CustoCompra), caso o custo de compra não for informado o produto 
não deverá aparecer na listagem; 

# O usuário deverá informar um valor para as despesas totais (DespesasTotais) da loja e estas despesas deverão ser rateadas igualmente entre os produtos 
(RateioDespesas), independentemente do valor destes. Caso o valor das despesas não seja informado o valor R$ 400,00 deverá ser assumido como padrão; 

# Opcionalmente o usuário poderá informa um percentual para margem de lucro (%MargemLucro). Este valor, se existir, deverá ser aplicado 
para encontrar o preço de venda de cada produto; 

# Todos os valores devem ser superiores a zero, exceto a margem de lucro que poderá ser maior ou igual a zero.