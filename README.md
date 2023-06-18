# CajasVolando

## List, GetKeyDown, Foreach, Random.Range, Count, Rigidbody, AddForce

### List:
Ofrece una amplia gama de métodos y propiedades adicionales para manipular y trabajar con listas de manera eficiente: Count, obtiene el numero de la lista.
Remove - elimina, Sort - Ordena en orden ascendente.

### GetKeyDown:
Se utiliza para detectar si una tecla específica se ha presionado en un solo fotograma. Es comúnmente utilizado en el desarrollo de juegos para capturar la entrada del usuario y responder a eventos de teclado.

### Foreach:
Se utiliza para iterar sobre una colección de elementos, como un array, una lista o cualquier otra estructura que implemente la interfaz IEnumerable. Proporciona una forma sencilla de recorrer todos los elementos de una colección sin necesidad de administrar un índice o un contador.

### Random.Range:
Se utiliza para generar un número aleatorio dentro de un rango específico. Permite generar números enteros o de punto flotante en un rango cerrado o abierto.

### Count:
Obtener la cantidad de elementos en una colección, como un array, una lista, un diccionario, entre otros. Esta propiedad devuelve un valor entero que representa el número de elementos en la colección.

### Rigidbody:
Se utiliza para simular la física de objetos en un escenario en 3D. Un componente Rigidbody se puede adjuntar a un objeto en Unity para permitir que interactúe con las fuerzas físicas, como la gravedad, colisiones, fricción y movimiento.

### AddForce:
Aplicar una fuerza a un objeto físico. Permite simular el movimiento y la interacción con las fuerzas físicas, como la gravedad, colisiones y otras fuerzas externas


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
