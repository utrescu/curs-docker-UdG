# Dia 1

Presentació ([aquí](https://docs.google.com/presentation/d/1zW82h1rE6VDcoiVfkBobVSjDTT3AKCsISjOICeiDfAA/edit?usp=sharing))

## Tasca 1: Instal·lació de Docker en el vostre sistema

- Instal·lar Docker

## Tasca 2: Executar programes dins de contenidors

- Quin és el resultat d'executar `cat /etc/lsb-release` en un contenidor Ubuntu?
- Dins d'un Ubuntu instal·leu `ipcalc` i calculeu les dades de la xarxa IP **84.88.12.23/25**

## Tasca 3: Executar nginx i mapejar el port en local

- Executeu un servidor `nginx` i l'exposeu el seu port a 8080
- Executeu un segon servidor `nginx` i exposeu-lo al port 8081
- Comproveu que tots dos funcionen sense problemes

## Tasca 4: Compilar programes

### Part 1

- Compileu i executeu el programa de `.\programa` sense instal·lar el compilador

> En Go el mateix interpret serveix per compilar i executar un programa. Per exemple:
>
> ```bash
> go run programa.go
> ```

### Part 2

- Instal·leu VSCode i la extensió "Remote Container"
- Feu servir la extensió per comprovar que es pot debugar i executar el programa en l'Ide

## Tasca 5: Volums de dades

- Engeguem un SqlServer o un MySQL, hi posem dades
- Eliminem el contenidor
- Creem un nou contenidor i li muntem les dades anteriors
- Comprovem que encara hi són
