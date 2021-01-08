# 3. Iniciar diversos contenidors

Es pot definir les prioritats d'arrencada dels contenidors de manera que en
cas d'actualitzacions es podrà determinar quins s'han de reiniciar.

Instruccions _docker-compose.yml_:

| Instrucció |                                                                       |
| ---------- | --------------------------------------------------------------------- |
| depends_on | Permet definir prioritats d'arrencada, però no espera els contenidors |
