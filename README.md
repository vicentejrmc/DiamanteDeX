# Diamante De X

## Descrição

- **O Programa foi desenvolvido para funcionar no modo ConsoleApp, e foi desenvolvindo em linguagem C#.**
 
## Funcionalidades:
 1. O programa recebe um número inteiro positivo ímpar `n` e imprime um diamante de tamanho `n` com a letra `X`.

 2. O programa faz a validação do numero digitado pelo usuário. 
 3. Caso não atenda os critérios(Ser número ímpar && Ser numero Positivo.) O sistema exibe uma mensagem especifica para o caso e
 solicita que o usuário digite um novo número até que os critérios sejam atendidos.

 4. O programa imprime um diamante de tamanho `n` com a letra `X`.
 
 5. Após impressão do diamante o programa pergunta ao usuário se deseja continuar: 
	1. caso a resposta seja sim, o programa reinicia, 
	2. caso a resposta seja não, o programa exibe mensagem para ser encerrado. 

## Exemplo

Para `n = 5`, a saída deve ser:
```
   X
  XXX
 XXXXX
  XXX
   X
  ```
  Para `n = 7`, a saída deve ser:

 ```
    X
   XXX
  XXXXX
 XXXXXXX
  XXXXX
   XXX
    X
```

## DEMO:

![](https://imgur.com/yIyMgMs)


  ## Como Execultar:

   1. Clone o repositorio ou baixe o codigo fonte.
   2. Abra o Terminal ou prompt de Comando e navegue até a pasta raiz.
   3. Utilize o camando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

   4. Compile a solução utilizando o comando:
```
 dotnet build --configuration Release
```

5.Para executar o projeto compilando em tempo real
```
dotnet run --project DiamanteDeX.ConsoleApp
```
	6. Para executar o arquivo compilado, navegue até a pasta:
 /DiamanteDeX.ConsoleApp/bin/Release/net8.0/ e execute o arquivo: 
  DiamanteDeX.ConsoleApp.exe   

  ## Requisitos de Sistema.

  .NET SDK (recomendado .NET 8.0) ou superior)
