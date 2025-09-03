## Arquitectura y Comunicación

- Los clientes se comunican con la API mediante peticiones HTTP (GET, POST, PUT, DELETE), generalmente usando URLs como `/api/productos` y enviando/recibiendo datos en formato JSON.

## Ventajas de REST

- Escalabilidad sencilla (stateless).
- Interoperabilidad con cualquier tecnología.
- Uso de estándares abiertos (HTTP, JSON).
- Soporte para balanceadores de carga y caché.

## Persistencia y Escalabilidad

- Los datos se almacenan en una base de datos externa.
- El servicio puede escalar fácilmente usando contenedores (Docker) y orquestadores (por ejemplo, Kubernetes).
- El balanceo de carga permite distribuir las peticiones entre varias instancias.
