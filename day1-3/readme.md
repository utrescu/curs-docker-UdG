# 3. Executar serveis i exposar ports

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
