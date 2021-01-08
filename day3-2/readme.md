# 2. Iniciar diversos contenidors

De la mateixa forma que el fitxer [Yaml](https://learn.getgrav.org/16/advanced/yaml) es pot fer servir per iniciar un contenidor es pot fer servir per iniciar-ne més d'un

Un dels efectes és que els contenidors poden resoldre els noms dels altres contenidors

Comandes docker-compose:

| comanda                | Resultat                             |
| ---------------------- | ------------------------------------ |
| docker-compose exec    | executa un programa en el contenidor |
| docker-compose stop    | Atura un contenidor amb el seu nom   |
| docker-compose start   | Inicia el contenidor especificat     |
| docker-compose restart | reinicia el contenidor               |
| docker-compose rm      | Elimina el contenidor                |
| docker-compose build   | Construeix el contenidor             |

Instruccions _docker-compose.yml_:

| Instrucció |                                            |
| ---------- | ------------------------------------------ |
| tty        | Obrir un terminal en el contenidor         |
| ports      | mapeig de ports amb localhost              |
| restart    | El contenidor es reinicia si hi ha canvis? |
