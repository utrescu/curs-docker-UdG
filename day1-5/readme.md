# 5. Executar una base de dades i no perdre les dades

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
