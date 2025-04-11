FROM ghcr.io/amacneil/dbmate

ENTRYPOINT ["/bin/sh", "-c"]

CMD ["trap \"echo Shutting down; exit 0\" SIGTERM SIGINT SIGKILL; /bin/sleep infinity & wait"]