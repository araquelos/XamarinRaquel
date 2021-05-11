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
1. Em `App.iOS` -> `Asset Catalogs` -> `Assets`, exclua a atual biblioteca de ícones `AppIcon`.
2. Em `App.iOS` -> `Asset Catalogs` -> `Assets`, adicione uma nova biblioteca de ícones em `App Icons` -> `Add App Icon`.
3. Altere o nome da nova biblioteca para `Icone`, e adicione as respectivas imagens ao lugar correspondente aos seus respectivos tamanhos.
4. Em `App.iOS`, abra o arquivo `Info.plist`.
5. Na aba `Visual Assets`, altere o source em `App Icones` para `Icone`.
### UWP

## SplashScreens
### Android
1. Em `App.Android` crie a activity `SplashActivity.cs`, e coloque nele o seguinte código:
```html
    [Activity(Theme = "@style/MainTheme.Splash", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            // Disable activity slide-in animation
            OverridePendingTransition(0, 0);
        }
    }
```
2. Em `App.Android`, abra o arquivo `MainActivity.cs`, e remova a linha `MainLauncher = true`.
3. Em `App.Android` -> `Resources` -> `values`, abra o arquivo `styles.xml`, e inclua nele o seguinte código:
```html
  <style name="MainTheme.Splash" parent ="Theme.AppCompat.Light.NoActionBar">
    <item name="android:windowBackground">@drawable/splashscreen</item>
    <item name="android:windowNoTitle">true</item>
    <item name="android:windowFullscreen">true</item>
    <item name="android:windowContentOverlay">@null</item>
    <item name="android:windowActionBar">true</item>
  </style>
```
4. Em `App.Android` -> `Resources` cole as novas pastas `drawable`.
5. Em `App.Android` -> `Resources` -> `drawable`, crie o xml `splashscreen.xml`, e inclua nele o seguinte código:
```html
<?xml version="1.0" encoding="utf-8" ?>
<layer-list xmlns:android="http://schemas.android.com/apk/res/android">
  <item>
    <color android:color="@color/ic_launcher_background"/>
  </item>
  <item>
    <bitmap
        android:src="@drawable/logo"
        android:tileMode="disabled"
        android:gravity="center"/>
  </item>
</layer-list>
``` 
6. Ainda em `App.Android` -> `Resources` -> `drawable`, edite o xml `splashscreen.xml` para incluir a imagem de splashscreen na linha `android:src="@drawable/SplashScreen"`. 
### iOS
1. Precisa de um Mac :(
### UWP
