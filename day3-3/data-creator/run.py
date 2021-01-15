import os
import sys
import time
import mysql.connector

sqlCreate = "CREATE TABLE persones (Id INT AUTO_INCREMENT PRIMARY KEY, Nom VARCHAR(255))"
sqlInsert = "INSERT INTO persones (Nom) VALUES (%s)"
stmt = "SHOW TABLES LIKE 'persones'"


def getenvordefault(env_var, default):
    "Check if the value ís none"
    data = os.getenv(env_var)
    if data == None:
        return default
    return data


host = getenvordefault("DATABASE_HOST", "172.17.0.2")
user = getenvordefault('DATABASE_USER', "jo")
password = getenvordefault('DATABASE_PASSWORD', "patata")
dbname = getenvordefault('DATABASE_NAME', "Persones")

ready = False
while not ready:

    try:
        mydb = mysql.connector.connect(
            host=host,
            user=user,
            password=password,
            database=dbname
        )
        mycursor = mydb.cursor()
        mycursor.execute(stmt)
        result = mycursor.fetchone()
        if not result:
            mycursor.execute(sqlCreate)

        ready = True

        with open('noms', 'r', encoding='utf8') as text_file:
            name = text_file.readline()
            while name:
                data = (name.strip(),)
                mycursor.execute(sqlInsert, data)
                mydb.commit()

                name = text_file.readline()

        mydb.close()

    except Exception as e:
        print("Esperant la base de dades", repr(e))
        time.sleep(3)


print("Insertats!")
