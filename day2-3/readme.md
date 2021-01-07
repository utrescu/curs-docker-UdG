# 3. Fitxers Dockerfile

En general el que es vol és crear imatges que puguin ser creades automàticament (ha canviat el codi font, ...). Per això existeixen els fitxers **Dockerfile**

Comandes fetes servir:

| paràmetre    | resultat                                 |
| ------------ | ---------------------------------------- |
| docker build | Crea una imatge seguint les instruccions |

Instruccions _Dockerfile_:

| Instrucció |                                              |
| ---------- | -------------------------------------------- |
| FROM       | Imatge base                                  |
| RUN        | Executa comanda dins del contenidor          |
| ENTRYPOINT | Programa a executar                          |
| ENV        | Defineix una variable d'entorn al contenidor |
