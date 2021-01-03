FROM ubuntu

RUN apt -y update
RUN apt-get install -y cowsay
ENV TEXT ”Hola”

ENTRYPOINT /usr/games/cowsay $TEXT
