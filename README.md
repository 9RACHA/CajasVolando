# CajasVolando

Realizar un juego en Unity que muestre unas cajas (simples cubos en realidad) en la escena y
permita hacer las siguientes funciones.

Se suministra un paquete que contiene un prefab para la caja. Este prefab incluye el
comportamiento de la caja necesario para aplicarse un material aleatorio entre una lista de
materiales disponibles al inicio del juego. También se dispone de un método para dar un impulso a
la caja en una dirección y con una fuerza aleatoria.

El objeto que hace de controlador del juego “GameManager”, debe tener una lista de las cajas que hay en la
escena.

Al presionar la barra espaciadora el controlador del juego aplicará un impulso a todas las cajas que
tiene registradas, llamando al correspondiente método de la caja.

Al presionar la tecla D (por delete) el controlador destruirá una de las cajas seleccionada al azar.

Al presionar la tecla C (por cambio) cada caja se cambiará su material, y en consecuencia su color.
El cambio no se hará al azar, sino que se avanzará al siguiente material disponible dentro de la lista
de materiales. Si se alcanza el final de la lista se volverá al principio.

Al presionar la tecla R (por reinicio) cada caja volverá a su posición y orientación iniciales.
