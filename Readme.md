# Patrones de Diseño

Un patrón de diseño no es más que una “receta” que trata de proporcionar una solución genérica a un problema concreto que se repite con frecuencia durante el desarrollo de software.

## Categorías de patrones de diseño

Existen una serie de categorías para definir la función que realizaba un patrón de diseño. A grandes rasgos, los patrones se dividen en tres grupos:

|Patrones|Descripción|
|---------|-----------|
|__Creacionales__|Se trata de un conjunto de patrones cuyo objetivo es el de instanciar objeto, en lugar de recurrir a la instanciación directa.|
|__Estructurales__|Definen una composición de objetos que, a través de especialización, proporcionan una funcionalidad determinada.|
|__De Comportamiento__|Se centran en cómo interactúan e intercambian información unos objetos con otros de una manera definida.|

# Patrones de Creación

Son aquellos en los que se delegaba la instanciación de un objeto en otro en lugar de recurrir a un simple new().

## Builder (constructor)

Separar la construcción de un objeto complejo de su representación, de modo que el mismo proceso de construcción pueda crear representaciones diferentes.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Builder/builder.png)

## Prototype

Especificar el tipo de objetos que se crearán utilizando una instancia prototipada y crear nuevos objetos realizando copias de ese prototipo. El concepto de este patrón es simple: en lugar de crear un objeto, se clona, es decir, se realiza una copia exacta de otro objeto dado, denominado prototipo. En .NET este proceso es sencillo, ya que nos ofrece la interfaz ICloneable que expone el método Clone(), método en el que habrá que codificar el proceso de copia. Ademas .NET también ofrece un método, MemberwiseClone(), que automáticamente realiza una copia del objeto por nosotros, evitándonos el proceso de copiar elemento por elemento de forma manual.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Prototype/prototype.png)

#### Clonación superficial y clonación profunda

Cuando invocamos el método MemberwiseClone() observamos que en su descripción indicaba que se realizaba una clonación shallow o superficial. Esto significa que el clonado se realiza a nivel de bits, por lo que los objetos contenidos dentro del objeto a clonar no se clonarán también, sino que se clonará únicamente la referencia del objeto. Por lo tanto, ambos objetos clonados apuntarán al mismo objeto. Esto es lo que se conoce como clonación superficial. El proceso por el cual se clonan los objetos incluidos en el objeto a clonar en lugar de copiar sus referencias se denomina clonación profunda.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Prototype/ClonacionSuperficial.png)
![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Prototype/ClonacionProfunda.png)

## Singleton

Asegurarse que una clase tiene una única instancia, proporcionando acceso global a ella. Hay clases que deben instanciarse una única vez. El acceso a un sistema de archivos, a la cola de impresión o al gestor de ventanas del sistema operativo debería realizarse por un único objeto, siendo labor de la propia clase el controlar que la instancia sea única. Por norma general, esta clase será accesible de forma global, y el proceso de instanciado no suele requerir parámetros.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Singleton/Singleton.png)

# Patrones Estructurales

# Patrones de Comportamiento

## Observer

Definir una dependencia uno-a-muchos entre objetos de forma de que, cuando el estado de uno de ellos cambia, todos los objetos dependientes son notificados y actualizados de forma automática.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Observer/Observer.png)

## Strategy

Definir una familia de algoritmos, encapsular cada uno de ellos y hacerlos intercambiables. Strategy permite cambiar el algoritmo independientemente de los clientes que lo utilicen.
El nombre de este patrón evoca la posibilidad de realizar un cambio de estrategia en tiempo de ejecución sustituyendo un objeto que se encargará de implementarla.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Strategy/Strategy.png)

## Principios SOLID

  * **Responsabilidad única** `(Single responsibility principle)`: Un objeto sólo debe tener una única responsabilidad.
  * **Abierto/cerrado** `(Open/closed principle)`: Una clase debe estar abierta para su extensión, pero cerrada para su modificación. Ejm: Uso de clase abstracta.
  * **Principio de sustitución de Liskov** `(Liskov substitution principle)`: Una clase padre siempre debe poder ser sustituida por una clase hija sin alterar el comportamiento del programa. No modificar comportamiento de la clase padre en las hijas.
  * **Segregación de la Interfaz** `(Interface segregation principle)`: Es preferible contar con muchas interfaces específicas que con una de propósito general. Todas las clases que implementan interfaces deben usar todos los metodos.
  * **Inversión de dependencia**  `(Dependency inversion principle)`: Se debe depender de abstracciones, no de concreciones.
