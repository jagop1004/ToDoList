#!/bin/bash

# Start SQL Server
/opt/mssql/bin/sqlservr &

echo "Waiting for SQL Server to start..."

# Wait until SQL Server is ready
for i in {1..60}
do
    /opt/mssql-tools18/bin/sqlcmd \
        -S localhost \
        -U sa \
        -P "mi_password_secreta123" \
        -C \
        -Q "SELECT 1" > /dev/null 2>&1

    if [ $? -eq 0 ]
    then
        echo "SQL Server is ready!"
        break
    fi

    sleep 2
done

echo "Running SQL scripts..."

# Execute every .sql file in alphabetical order
for file in /usr/config/*.sql
do
    echo "Executing $file"

    /opt/mssql-tools18/bin/sqlcmd \
        -S localhost \
        -U sa \
        -P "mi_password_secreta123" \
        -C \
        -i "$file"

    if [ $? -ne 0 ]
    then
        echo "Error while executing $file"
        exit 1
    fi
done

echo "All scripts executed successfully!"

wait