# 1. Executar contenidors amb docker-compose

Docker-compose es pot fer servir per executar contenidors definint els paràmetres
en un fitxer [Yaml](https://learn.getgrav.org/16/advanced/yaml)

Comandes per gestionar docker-compose:

| comanda             | Resultat                   |
| ------------------- | -------------------------- |
| docker-compose up   | Inicia els contenidors     |
| docker-compose down | Atura tots els contenidors |

Instruccions _docker-compose.yml_:

| Instrucció  |                                                           |
| ----------- | --------------------------------------------------------- |
| services    | Secció amb els contenidors                                |
| image       | Defineix la imatge que farà servir un "servei"            |
| environment | Defineix variables d'entorn que farà servir el contenidor |
