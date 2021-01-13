# Dia 2

Presentació ([aquí](https://docs.google.com/presentation/d/1FugK5vONYescJq7FaY1NABirlihU10fVPw52gAT4Zjk/edit?usp=sharing))

- [PDF](Presentacio.pdf)

## Tasca 1: Crear una imatge a partir d'un contenidor

- En una imatge de SQLServer afegiu-hi dades
- Creeu una imatge del contenidor

## Tasca 2: Distribuir imatges

- Importeu la imatge `aliga.tar` del directori `day2-2` i executeu-la.
- Creeu-vos un compte a Docker Hub
- Penjeu la vostra imatge a Docker Hub
- Poseu-vos en contacte amb un company i proveu la seva imatge (o descarregueu la que hem creat durant la presentació)

## Tasca 3: Crear imatge que executa un programa

- Creeu una imatge d'Ubuntu que quan l'executem cridi a `cowsay` amb un missatge que surti d'una variable d'entorn.
- Executeu la imatge passant-li com a paràmetre una variable d'entorn amb un missatge diferent.

- Creeu una imatge de Alpine en la que s'executi el programa que està dins del fitxer `aliga.tar.gz`

## Tasca 4: Empaquetar una web amb el servidor

- Creeu una imatge del servidor Apache Httpd que contingui la web del directori
- Comproveu que la podeu veure des de la màquina local

## Tasca 5: Crear imatge a partir de codi font

- Creeu un projecte de C# en local
- Fent servir la imatge del seu compilador creeu un Dockerfile que compili el programa i defineixi el punt d'entrada amb el binari generat

> Des de consola es pot crear un projecte de consola .Net5 amb:
>
> ```csharp
> dotnet new console -o directori
> ```
>
> o un projecte web
>
> ```csharp
> dotent new mvc
> ```
>
> De totes formes es pot fer servir Visual Studio...

## Tasca 6: Crear imatges "primes"

- Tenim un programa en Go (Golang) en el directori _./day2-6/aliga_ i volem crear un contenidor per executar-lo. Com que no necessita gaire res el volem en un **Alpine Linux**.
- Creeu de nou la imatge de la tasca5 però amb un procés de dues fases de manera que la imatge resultant no tingui dins seu el codi font, només l'executable

## Vull més feina! I sense ajuda

- Feu un programa, en el llenguatge que vulgueu, que compti les paraules d'un text i empaqueteu-lo en un contenidor.
  - El text que ha d'avaluar li ha d'arribar en una variable d'entorn
