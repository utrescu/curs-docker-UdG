# 6. Aprimar imatges

Com més instruccions tingui el Dockerfile més gran es farà la imatge resultant. El procés de construcció en dues fases permet generar imatges més petites

| Instrucció   |                                                     |
| ------------ | --------------------------------------------------- |
| FROM .. AS   | Imatge que es pot referenciar amb un nom            |
| COPY --from= | Copia coses des de la imatge amb el nom especificat |
