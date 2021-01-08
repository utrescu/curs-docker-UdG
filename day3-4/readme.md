# 4. Construir imatge i executar-la

Els fitxers `docker-compose` no només poden fer servir imatges existents, també
en poden crear de noves a partir de fitxers _Dockerfile_

Comandes docker-compose:

| comanda              | Resultat                   |
| -------------------- | -------------------------- |
| docker-compose build | Reconstrueix el contenidor |

Instruccions _docker-compose.yml_:

| Instrucció |                                                    |
| ---------- | -------------------------------------------------- |
| build      | Defineix que la imatge s'ha de construir           |
| context    | Defineix on hi ha l'arrel de la imatge a construir |
