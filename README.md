# Dia 2

Presentació ([aquí](https://docs.google.com/presentation/d/1FugK5vONYescJq7FaY1NABirlihU10fVPw52gAT4Zjk/edit?usp=sharing)

## 1. Crear imatges

Normalment no es volen imatges verges sinó que el que es vol és tenir una imatge
amb el nostre contingut. Es poden crear imatges a partir de contenidors en marxa

Comandes docker fetes servir:

| paràmetre     | resultat                       |
| ------------- | ------------------------------ |
| docker commit | Crea un contenidor i l'executa |

## 2. Penjar la imatge en un repositori

Un cop feta la imatge. També la voldrem enviar a un repositori per poder-la obtenir
quan ens faci falta

| paràmetre    | resultat                       |
| ------------ | ------------------------------ |
| docker login | Identificació en el repositori |
| docker push  | Envia una imatge al repositori |

## 3. Fitxers Dockerfile

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

## 4. Empaquetar una web amb el servidor

En les imatges s'hi pot empaquetar qualsevol tipus de dades. També fitxers:

Instruccions _Dockerfile_:

| Instrucció |                                                 |
| ---------- | ----------------------------------------------- |
| COPY       | Copia fitxers i directoris locals al contenidor |
| EXPOSE     | Notifica que s'exposen ports (només informació) |

## 5. Empaquetar programa des de codi font

Les imatges no tindrien sentit si no es pogués automatitzar tot el procés de desenvolupament

Instruccions _Dockerfile_:

| Instrucció |                                                  |
| ---------- | ------------------------------------------------ |
| WORKDIR    | Canvia el directori de referència del contenidor |

## 6. Aprimar imatges

Com més instruccions tingui el Dockerfile més gran es farà la imatge resultant. El procés de construcció en dues fases permet generar imatges més petites

| Instrucció   |                                                     |
| ------------ | --------------------------------------------------- |
| FROM .. AS   | Imatge que es pot referenciar amb un nom            |
| COPY --from= | Copia coses des de la imatge amb el nom especificat |
