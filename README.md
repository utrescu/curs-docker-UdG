# Dia 1

Presentació ([aquí](https://docs.google.com/presentation/d/1zW82h1rE6VDcoiVfkBobVSjDTT3AKCsISjOICeiDfAA/edit?usp=sharing))

## 1. Instal·lació de Docker

Docker està basat en Linux però hi ha versións per els grans sistemes operatius Windows, MacOs. [Aquí](https://docs.docker.com/get-docker/)

La instal·lació bàsica de Linux només conté el motor de Docker mentre les versions de Windows i MacOs són un paquet d'aplicacions (Docker Desktop)

> En Windows hi ha característiques diferents en funció de la versió:
>
> | Versió                          |                                                                                   |
> | ------------------------------- | --------------------------------------------------------------------------------- |
> | Windows 10 Home                 | Necessita WSL 2. Només executa contenidors Linux                                  |
> | Windows 10 professional, Server | Necessita HyperV, Windows containers, Permet executar contenidors Windows i Linux |
>
> En general els contenidors Linux són més ràpids en WSL2

Docker en Windows es pot administrar des de la barra de tasques

![Docker en Windows](images/docker-windows.png)

![Docker en Windows](images/docker-windows2.png)

### Tasca1

- Instal·lar Docker

## 2. Executar programes en Ubuntu

L'objectiu dels contenidors és executar programes. Mentre el programa estigui
en marxa el contenidor estarà en marxa

Comandes docker fetes servir:

| paràmetre           | resultat                        |
| ------------------- | ------------------------------- |
| docker run          | Crea un contenidor i l'executa  |
| docker ps [-a]      | Mostra l'estat dels contenidors |
| docker container ls | Mostra els contenidors          |
| docker stop         | Atura un contenidor             |
| docker container rm | Elimina el contenidor           |
| docker image ls     | Mostra les imatges locals       |
| docker image rm     | Elimina una imatge local        |

Opcions:

| Opció | objectiu                                |
| ----- | --------------------------------------- |
| -ti   | obtenir un terminal dins del contenidor |

> D'on surten les imatges?
>
> Per defecte les imatges surten del ["Docker Hub"](https://hub.docker.com/), però hi ha molts repositoris
> d'imatges i és fàcil de crear-ne de privats

### Tasca2

- Quin és el resultat d'executar `cat /etc/lsb-release`
- Dins d'un Ubuntu instal·lem `ipcalc` i calculem les dades de la xarxa IP **84.88.12.23/25**

## 3. Executar serveis i exposar ports

Els contenidors tenen un temps de vida més llarg quan executen serveis ja que
no acaben fins que s'atura o es mata el contenidor

Comandes docker fetes servir:

| paràmetre      | resultat                        |
| -------------- | ------------------------------- |
| docker run     | Crea un contenidor i l'executa  |
| docker ps [-a] | Mostra l'estat dels contenidors |

Opcions interessants:

| Opció                        | objectiu                                       |
| ---------------------------- | ---------------------------------------------- |
| -d                           | Executa el contenidor com un servei            |
| --rm                         | Mata automàticament el contenidor quan s'atura |
| -p portlocal: portcontenidor | exposa ports                                   |

### Tasca3

- Executem un servidor `nginx` i l'exposem en un port local

## 4. Compilar programes sense instal·lar compilador

### Treballar amb consola

Amb un contenidor que tingui el llenguatge de programació en tenim prou per compilar i executar programes.

Opcions interessants:

| Opció                                | objectiu              |
| ------------------------------------ | --------------------- |
| -v carpeta local: carpeta contenidor | Comparteix la carpeta |

### Tasca4a

- Compilem i executem el programa de `.\day1-4\programa` sense instal·lar el compilador

> En Go el mateix interpret serveix per compilar i executar un programa. Per exemple:
>
> ```bash
> go run programa.go
> ```

### IDE

El VSCode té una extensió "Remote Container" que permet treballar directament en el contenidor. Permet editar i executar programes.

## Tasca4b

- Instal·lem VSCode i la extensió "Remote Container" i la fem servir per executar el mateix programa anterior.

## 5. Executar una base de dades i no perdre les dades

En Docker també es poden fer servir "volums de dades" que serveixen per no perdre les dades entre execucions d'un contenidor o per compartir-les entre diferents contenidors.

Comandes docker fetes servir:

| paràmetre            | resultat                  |
| -------------------- | ------------------------- |
| docker volume create | Crea un volum de dades    |
| docker volume rm     | elimina el volum de dades |

Opcions interessants:

| Opció                           | objectiu       |
| ------------------------------- | -------------- |
| -v volum: carpeta al contenidor | munta el volum |

## Tasca5

- Engeguem un SqlServer o un MySQL, hi posem dades
- Eliminem el contenidor
- Creem un nou contenidor i li muntem les dades anteriors
- Comprovem que encara hi són
