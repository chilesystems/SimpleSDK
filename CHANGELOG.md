# Changelog

Todos los cambios notables a este proyecto serán documentados en este archivo.

## [1.0.0] - 04-10-2021

Primera versión de prueba

## [1.0.1] - 25-11-2021

Se agregan todas las opciones básicas para la operación tributaria:
Generación de DTE en XML
Generación de sobre de envío
Envío al SII
Consulta de Estados
Generación de muestra impresa (formato estándar)

## [1.1.0] - 12-07-2022

Se agregan los endpoints de las APIs:
Boleta de Honorarios
Folios
RCV (Registro de Compras y Ventas)

## [1.2.8] - 09-12-2024
Se corrige TipoCompra en las Ventas, cuando debería decir TipoVenta
La información se obtene ahora desde los CSV que se descargan desde el SII

## [1.2.9] - 16-12-2024
Se incorpora endpoint para listar comunas

## [1.3.0] - 31-01-2025
Se corrige verbo de petición para la consulta de Folios, de GET a POST.

## [1.3.1] - 30-06-2025
Se agrega el método EnviarCesionAsync para enviar cesiones electrónicas.

## [1.4.1] - 28-11-2025
Se corrige verbo de petición para la consulta de BHE, de GET a POST.