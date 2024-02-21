
## Conhecimentos aplicados

º Como abrir uma conexão entre a API e o banco de dados através do EntityFramework.

º Como gerar migrations com .NET 6 e mapear nosso objeto no banco de dados.

º O DbContext serve como ponte e para fazer operações no banco.

º Como filtrar recursos para retornar para o usuário utilizando LINQ.

º Status 404 indica que um recurso não foi encontrado.

º Como aplicar paginação através dos métodos Skip() e Take().

## Frameworks
![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/570b004a-8fb6-48e5-b517-c5cdefd1b80d)

## Swagger
![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/3d8bc13c-aa44-4f37-8b62-cd9c9a6d510d)



## Documentação

O intuito desta Api é para coletar dados do usuario como Nome Completo, E-mail e o cargo, após a coleta conseguimos incluir todas as informações com o POSTMAN

a seguir deixarei incluso partes importantes do código fonte.

Nesta clase está incluso todas as informações em código fonte para está adicionando informações na Api
temos HTTPost, HttpGet, HttPut, HttDelete, Httpatch, todos esses Http estão funcionando corretamente, sem eles não conseguiremos adicionar nenhuma informações a nossa Api
eles são muito imporante para utilização do projeto. 
![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/3a61b67a-7951-43b7-8ec9-441522264b95)

Temos também a pasta Dtos que é fundamental nela está incluso o CreateApi, ReadApiDto, UpdateApiDto, são utilizados para efetuar transferências de dados entre as clases desta aplicação 
![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/b90198ea-8586-4c3f-8437-7f73eb1e2d76)

ApiContext utilizada para ter total acesso ao banco de dados que é fundamental a utilização.
![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/046f5b29-a994-4f30-81a7-417ed305ddd0)


Utilizamos o Migration para conectividade com o banco de dados e efetuar criações de tabelas dentro dela
![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/2734709f-be3a-4140-b793-23492642e8d9)

Por ultimo o mais importante a classe Program onde foi incluido todos os acesso ao automapper, coenctividade ao banco de dados para maior funcionanmento da aplicação. 
![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/c1b4e425-3ed2-4be4-a709-212b443459e2)



Utilizado o PostMan para adicionar informaçãoes na Api, como consultar, adicionar, deletar, modificar.

Neste projeto conseguimos consultar cada elemento por ID, pois tem integridade com o banco de dados, cada elemento salvo vai gerar um ID expecifico para aquele item. 

Utilizando O POST
![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/ad72619f-886c-4d11-a82f-2faed70ea3d2)


Utilizando o GET

![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/adb5869d-7eb1-4a56-8617-904fb92fc03b)

Utilizando o DELETE

![image](https://github.com/VitorRoque1/MinhaPrimeiraApi/assets/153464680/2d161edc-983a-4663-883f-17c6c1dcbfd9)





