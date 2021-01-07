# Dia 3

Presentació ([aquí](https://docs.google.com/presentation/d/1Ap0gw2PujJWGaw5-PC2BDP4NsNsNyI2LHwGfjv5SuoQ/edit?usp=sharing)

## Tasca 1: Executar MySQL amb docker-compose

- Executeu una instància de MySQL o MariaDb fent servir Docker-compose

## Tasca 2: Iniciar dos contenidors

- Feu un docker-compose que permeti executar un Ubuntu i una base de dades
- En el contenidor Ubuntu instal·leu-hi el paquet `iputils-ping`
- Comproveu que podeu fer ping al contenidor de base de dades amb el seu nom

## Tasca 3: Iniciar dos contenidors amb dependències

- Desenvolupeu un fitxer `docker-compose` que executi la imatge `utrescu/data-creator` i una base de dades MySQL. Definiu que la base de dades depèn del data-creator
- Comproveu que la base de dades conté dades en la taula `Persones`
- Desplegueu un contenidor Wordpress amb una base de dades MySQL

## Tasca 4: Construir imatge i executar-la

- Feu un docker-compose que permeti iniciar l'aplicació weatherforecast creant-ne la imatge a partir del seu Dockerfile i mapejeu el port 80 al port local 8080
- Comproveu que funciona anant amb un navegador a http://localhost:8080/WeatherForecast

## Tasca 5: Construir un programa amb més components

Teniu un programa que fa servir SQLServer, un servei REST (ColorsWebService) que recupera les dades de la base de dades i una Web en Blazor (espantApp) que fa peticions al servei Web.

- Construiu el fitxer docker-compose.yml que permeti iniciar el sistema amb una sola comanda.
