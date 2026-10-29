# BlazorDbzPersonagem

Aplicação Blazor WebAssembly do exercício 20: consulta um personagem da Dragon Ball API pelo ID e mostra nome, planeta de origem e todas as transformações retornadas.

## Executar

Pré-requisito: SDK .NET 10 e acesso à Internet (restauração NuGet, dados e imagens).

```powershell
dotnet restore
dotnet run
```

Abra no navegador a URL exibida pelo terminal. A consulta acontece no navegador, por HTTPS, sem chave de API. Para encerrar, pressione Ctrl+C.

## Usar

1. Informe um ID inteiro positivo.
2. Clique em **Buscar personagem** ou pressione Enter.
3. Confira nome, planeta e lista completa de transformações, incluindo imagens e Ki quando fornecidos.

Exemplos: `1` (Goku), `2` (Vegeta). O aplicativo mostra estados de carregamento, ID inválido, personagem inexistente, timeout e falha de rede, além de tratar personagens sem planeta ou transformações cadastradas. Os textos dos personagens permanecem como fornecidos pela API.

## API e modelos

- Endpoint: `https://dragonball-api.com/api/characters/{id}`.
- Nome: `name`.
- Planeta de origem: `originPlanet.name`.
- Transformações: todos os elementos de `transformations` (`id`, `name`, `image`, `ki`).
- Fonte: [Dragon Ball API](https://web.dragonball-api.com/).

`Models/Character.cs` contém os modelos. `Pages/Home.razor` valida a entrada e faz a consulta assíncrona por `HttpClient`, com limite de 20 segundos.

## Verificação

```powershell
dotnet build
```

Cenários manuais: buscar 1 e 2; testar ID vazio, zero e negativo; buscar um ID inexistente; simular rede offline; verificar todos os cartões de transformação e a apresentação em tela estreita. A disponibilidade do serviço externo depende do provedor.

## Publicação

```powershell
dotnet publish -c Release
```

Para hospedagem estática, utilize `bin/Release/net10.0/publish/wwwroot` e configure o servidor para retornar `index.html` nas rotas do aplicativo. Para hospedagem em subpasta, ajuste o `<base href>` em `wwwroot/index.html`.

O `.gitignore` segue o modelo Visual Studio do SDK: `bin/`, `obj/`, configurações de IDE e arquivos locais não são entregues ao GitHub.

## Licença

Código sob licença MIT. Dragon Ball, personagens e imagens pertencem aos respectivos titulares e são fornecidos pela API para esta atividade educacional.
