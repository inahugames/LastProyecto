Al menos las entidades **Cliente**, **Producto**, Clase **registración**, **Vendedor**

El sistema deberá ser lo más genérico posible con el fin de poder aplicario a cualquier empresa a cualquier negocio que necesite un sistema de facturación. Por lo tanto se requiere que los productos tengan al menos un **código alfanumérico** y no debe faltar el **costo**, el **precio** y la **existencia**.

Los clientes podrán ser personas fisicas o bien empresas por lo tanto la clave que va a identificar la abstracción que corresponde a cliente deberá tener una propiedad código la cual podria albergar tanto un numero **documento como un CUIT/CUIL**
El sistema deberá contener en algún lugar una **lista de clientes** cómo así también una **lista de productos**. Por otro lado, la clase que se ocupe del registro deberá guardar un **histórico de las operaciones**. Esto permitirá que al momento de realizar una consulta sobre un cliente podamos ver los productos comprados o bien que al realizar una vista sobre un producto en particular podamos ver qué clientes adquirieron ese producto.

El sistema tendrá en cuenta la posibilidad del **cálculo del IVA**, del **cálculo de descuentos** que podrá ser cargados en forma manual o bien asignados dependiendo del tipo de producto vendido también.

Podria ser una opción que cuando se compre más de un producto del mismo tipo reciba un porcentaje de descuento sobre el monto total de la compra.
Debe registrar el modo de pago y el medio de pago.
Puede persistir datos en archivos CSV.
