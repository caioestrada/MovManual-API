# Movimentos Manuais

Aplicação para realizar consultas e inserir produtos.

## Tecnologia

Web Api - **ASP NET Framework 4.5**

## Instalação

Para executar a aplicação é necessário a criação de um banco de dados. Para isso, é preciso ter o Sql instalado ou subir um via docker.

Para subir o Sql via docker, executar o seguinte comando:

```docker
docker run --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=1a2b3c4d@" -p 1433:1433 -d mcr.microsoft.com/mssql/server
```

Com o Sql rodando, abrir a aplicação no visual studio, selecionar a opção Tools -> Nuget Package Manager -> Package Manager Console, selecionar o projeto "MovimentosManuais.Infra.Data" como Default project e executar o seguinte comando:

```
Update-database
```

O banco sera criado logo após o comando ser executado com sucesso.