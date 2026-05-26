FROM mcr.microsoft.com/mssql/server:latest

USER root

# Create init directory
RUN mkdir -p /usr/config

# Copy SQL scripts
COPY scripts/*.sql /usr/config/

# Copy startup script
COPY scripts/entrypoint.sh /usr/config/

# Give execution permissions
RUN chmod +x /usr/config/entrypoint.sh

USER mssql

CMD ["/bin/bash", "/usr/config/entrypoint.sh"]