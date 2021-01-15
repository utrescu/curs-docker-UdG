FROM python:3

WORKDIR /code

COPY . .

RUN pip install mysql-connector

ENV DATABASE_HOST="localhost"
ENV DATABASE_USER="root"
ENV DATABASE_PASSWORD="patata"
ENV DATABASE_NAME="Test"

CMD ["python", "./run.py"]

