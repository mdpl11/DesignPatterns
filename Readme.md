# Patrones de Diseño

Un patrón de diseño no es más que una “receta” que trata de proporcionar una solución genérica a un problema concreto que se repite con frecuencia durante el desarrollo de software.

## Categorías de patrones de diseño

Existen una serie de categorías para definir la función que realizaba un patrón de diseño. A grandes rasgos, los patrones se dividen en tres grupos:

|Patrones|Descripción|
|---------|-----------|.
|__Creacionales__|Se trata de un conjunto de patrones cuyo objetivo es el de instanciar objeto, en lugar de recurrir a la instanciación directa.|
|__Estructurales__|Definen una composición de objetos que, a través de especialización, proporcionan una funcionalidad determinada.|
|__De Comportamiento__|Se centran en cómo interactúan e intercambian información unos objetos con otros de una manera definida.|

# Patrones de Creación

Son aquellos en los que se delegaba la instanciación de un objeto en otro en lugar de recurrir a un simple new().

## Builder (constructor)

Separar la construcción de un objeto complejo de su representación, de modo que el mismo proceso de construcción pueda crear representaciones diferentes.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Builder/builder.png)

# Patrones Estructurales

# Patrones de Comportamiento

## Observer

Definir una dependencia uno-a-muchos entre objetos de forma de que, cuando el estado de uno de ellos cambia, todos los objetos dependientes son notificados y actualizados de forma automática.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Observer/Observer.png)

## Strategy

Definir una familia de algoritmos, encapsular cada uno de ellos y hacerlos intercambiables. Strategy permite cambiar el algoritmo independientemente de los clientes que lo utilicen.
El nombre de este patrón evoca la posibilidad de realizar un cambio de estrategia en tiempo de ejecución sustituyendo un objeto que se encargará de implementarla.

![alt tag](https://raw.githubusercontent.com/mdpl11/DesignPatterns/master/Strategy/Strategy.png)