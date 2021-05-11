# Nome da Solução
> Descrição da Solução.

## Cores
- Cor 1: `Hexadecimal 1`
- Cor 2: `Hexadecimal 2`
- Cor 3: `Hexadecimal 3`

## Nome do Aplicativo e Nome do Pacote
### Android
1. Botão da direita em `App.Android`, clique em `Propriedades`.
2. Na aba `Android Manifest`, altere o nome da aplicação em `Application name`.
3. Na aba `Android Manifest`, altere o nome do pacote em `Package name`.
4. Em `App.Android`, abra o arquivo `MainActivity.cs` e remova a `Label` da linha `[Activity(Label = "XamarinVIBE"...]`.
### iOS
1. Em `App.iOS`, abra o arquivo `Info.plist`.
2. Na aba `Application`, altere o nome da aplicação em `Application Name`.
3. Na aba `Application`, altere o nome do pacote em `Bundle Identifier`.
### UWP
1. Botão da direita em `App.UWP`, clique em `Propriedades`.
2. Na aba `Aplicativo`, clique no botão `Manifesto do Pacote`.
3. Na aba `Aplicativo`, altere o nome da aplicação em `Nome de exibição`.

## Ícones
### Android
1. Abra o arquivo `ic_launcher_background.xml` e copie a linha `<color name="ic_launcher_background">#0016a6</color>`.
2. Em `App.Android` -> `Resources` -> `values`, abra o arquivo `colors.xml`, e substitua a linha `<color name="launcher_background">#FFFFFF</color>` pela linha copiada na etapa anterior.
3. Em `App.Android` -> `Resources`, exclua todas as pastas `mipmap`.
4. Copie as novas pastas `mipmap` e cole em `App.Android` -> `Resources`.
5. Em `App.Android`, abra o arquivo `MainActivity.cs` e remova o `Icon` da linha `[Activity(Icon = "@mipmap/icon"...]`.
6. Compile só o projeto `App.Android`.
7. Botão da direita em `App.Android`, clique em `Propriedades`.
8. Na aba `Android Manifest`, altere o ícone da aplicação em `Application icon` para `@mipmap/ic_launcher`.
### iOS
### UWP

## SplashScreens
### Android
### iOS
### UWP
