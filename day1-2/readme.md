# 2. Executar programes en Ubuntu

L'objectiu dels contenidors és executar programes. Mentre el programa estigui
en marxa el contenidor estarà en marxa

Comandes docker fetes servir:

| paràmetre           | resultat                               |
| ------------------- | -------------------------------------- |
| docker run          | Crea un contenidor i l'executa         |
| docker ps [-a]      | Mostra l'estat dels contenidors        |
| docker inspect      | Proporciona informació sobre la imatge |
| docker container ls | Mostra els contenidors                 |
| docker stop         | Atura un contenidor                    |
| docker container rm | Elimina el contenidor                  |
| docker image ls     | Mostra les imatges locals              |
| docker image rm     | Elimina una imatge local               |

Opcions:

| Opció | objectiu                                |
| ----- | --------------------------------------- |
| -ti   | obtenir un terminal dins del contenidor |

> D'on surten les imatges?
>
> Per defecte les imatges surten del ["Docker Hub"](https://hub.docker.com/), però hi ha molts repositoris
> d'imatges i és fàcil de crear-ne de privats
