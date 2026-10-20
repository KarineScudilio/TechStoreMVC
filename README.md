
1- Qual é a responsabilidade da classe Categoria?
R: A classe Categoria representa uma categoria e armazena suas informações: código, nome, descrição e situação (ativa ou inativa).

2- Qual é a responsabilidade do CategoriasController
R: O CategoriasController recebe as requisições relacionadas às categorias, cria a lista de categorias e envia os dados para a View.

3- Por que a View utiliza uma lista em @model?
R: Porque a View precisa receber várias categorias, e não apenas um único objeto.

4- Para que serve o foreach?
R: O foreach percorre a lista de categorias e permite criar uma linha na tabela para cada categoria.

5- O que aconteceria se a pasta fosse criada como Views/Categoria, no singular?
R: Por padrão, o MVC procuraria a View na pasta Views/Categorias, no plural. Se ela estivesse apenas em Views/Categoria, a aplicação provavelmente informaria que a View não foi encontrada.

6- Qual caminho a aplicação percorre quando acessamos /categorias?
R: O navegador faz uma requisição GET para /categorias. O roteamento direciona a requisição ao CategoriasController, que executa a Action Index, cria a lista de categorias e envia essa lista para a View Views/Categorias/Index.cshtml. A View gera o HTML que é exibido no navegador.


Desafios adicionais

Desafio 1 — Contagem
R: Adicionei uma contagem acima da tabela para mostrar o total de categorias cadastradas. Como existem cinco categorias na lista, aparece a mensagem “Total de categorias: 5”.

Desafio 2 — Destaque visual
R: As categorias inativas recebem uma cor diferente para facilitar sua identificação na tabela, enquanto as categorias ativas continuam com a aparência normal.

Desafio 3 — Segunda rota
R: Criei a Action Ativas com a rota /categorias/ativas. Utilizei o método Where para selecionar somente as categorias que possuem Ativa = true e ToList() para transformar o resultado em uma lista. Depois, enviei essa lista para a View, mostrando apenas as categorias ativas.

Testes realizados
R: A rota /categorias deve mostrar as cinco categorias cadastradas, enquanto a rota /categorias/ativas deve mostrar somente as quatro categorias ativas.

Com essa atividade, consegui entender melhor como o Model, o Controller e a View trabalham juntos na arquitetura MVC para organizar e exibir as informações.