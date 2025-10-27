# Investigación sobre Estructuras de Datos

Las estructuras de datos son herramientas fundamentales en la programación, utilizadas para almacenar, organizar y manipular información de manera eficiente. Se clasifican en lineales, no lineales y abstractas, según la forma en que los elementos se relacionan entre sí.

---

## ESTRUCTURAS LINEALES

### 1. Arreglos (Arrays)

#### Definición
Un arreglo es una colección de elementos del mismo tipo, almacenados en posiciones contiguas de memoria. Cada elemento se accede mediante un índice.

#### Aplicaciones
- Almacenamiento de listas de datos del mismo tipo (números, caracteres, etc.).
- Implementación de matrices, vectores o tablas.
- Base para otras estructuras como pilas, colas y listas.

#### Métodos Comunes
- Insertar: agregar un elemento en una posición específica.  
- Eliminar: quitar un elemento.  
- Buscar: localizar un valor dentro del arreglo.  
- Recorrer: acceder a cada elemento secuencialmente.

---

### 1.1 Arreglo Unidimensional
#### Definición
Es un arreglo de una sola dimensión, similar a una lista lineal de elementos.

#### Aplicaciones
- Registro de calificaciones de estudiantes.
- Vector de temperaturas diarias.
- Listas de precios o inventarios.

#### Métodos Comunes
- Acceso por índice: `A[i]`
- Modificación: `A[i] = valor`
- Iteración con bucles.

![Arreglo Unidimensional](https://www.inesem.es/revistadigital/informatica-y-tics/files/2019/02/Array-Unidimensional.jpg)

---

### 1.2 Arreglo Multidimensional
#### Definición
Es un arreglo que contiene más de una dimensión (por ejemplo, una matriz bidimensional).

#### Aplicaciones
- Representación de imágenes o mapas.
- Tablas de datos (filas y columnas).
- Modelos matemáticos y simulaciones.

#### Métodos Comunes
- Acceso por coordenadas: `A[i][j]`
- Recorridos anidados.
- Operaciones matriciales (suma, multiplicación, transposición).

![Arreglo Multidimensional](https://controlautomaticoeducacion.com/wp-content/uploads/Arreglo-Multidimensional.png)

---

### 2. Pilas (Stacks)

#### Definición
Una pila es una estructura lineal que sigue el principio LIFO (Last In, First Out), donde el último elemento en entrar es el primero en salir.

#### Aplicaciones
- Deshacer acciones (Ctrl+Z).
- Llamadas a funciones (stack de ejecución).
- Conversión de expresiones matemáticas.

#### Métodos Comunes
- push(): insertar un elemento.
- pop(): eliminar el último elemento agregado.
- peek() / top(): ver el elemento superior sin eliminarlo.
- isEmpty(): verificar si está vacía.

![Pilas](https://25a5c98291.cbaul-cdnwnd.com/9e53414436e4c734724849e45af36c98/200000132-a6522a6524/pilas.png?ph=25a5c98291)

---

### 3. Colas (Queues)

#### Definición
Una cola es una estructura que sigue el principio FIFO (First In, First Out), donde el primer elemento en entrar es el primero en salir.

#### Aplicaciones
- Sistemas de atención (bancos, servidores).
- Manejo de procesos en sistemas operativos.
- Simulaciones de tráfico o líneas de espera.

#### Métodos Comunes
- enqueue(): insertar al final.
- dequeue(): eliminar al inicio.
- front() / rear(): acceder al primer o último elemento.
- isEmpty(): verificar si está vacía.

![Colas](https://media2.dev.to/dynamic/image/width=800%2Cheight=%2Cfit=scale-down%2Cgravity=auto%2Cformat=auto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Fj87zynigppdrtql0ymjh.png)

---

### 4. Listas Enlazadas (Linked Lists)

#### Definición
Una lista enlazada es una colección de nodos donde cada nodo contiene un dato y una referencia (enlace) al siguiente nodo.

#### Aplicaciones
- Implementación de pilas y colas.
- Manejo dinámico de memoria.
- Navegadores (historial adelante/atrás).

#### Métodos Comunes
- insertar(): agregar un nodo en una posición.
- eliminar(): quitar un nodo.
- buscar(): localizar un nodo.
- recorrer(): visitar cada nodo.

![Listas Enlazadas](https://www.oscarblancarteblog.com/wp-content/uploads/2014/07/listaligada.png)

---

#### 4.1 Lista Simplemente Enlazada
Cada nodo tiene un enlace al siguiente nodo.

**Aplicaciones:**  
Listas dinámicas simples, recorridos lineales.  

**Métodos:**  
insertarInicio(), insertarFinal(), eliminar(), mostrar().

![Lista Simplemente Enlazada](https://www.it.uc3m.es/java/2011-12/units/pilas-colas/guides/2/img/sl1-simple-list.png)

---

#### 4.2 Lista Doblemente Enlazada
Cada nodo tiene dos referencias: una al nodo anterior y otra al siguiente.

**Aplicaciones:**  
Sistemas de navegación (anterior/siguiente), editores de texto, control de desplazamiento.  

**Métodos:**  
insertarInicio(), insertarFinal(), eliminarNodo(), recorrerAmbosSentidos().

![Lista Doblemente Enlazada](https://ccia.ugr.es/~jfv/ed1/tedi/cdrom/icons/lenlaz2.gif)

---

#### 4.3 Lista Circular
El último nodo apunta nuevamente al primer nodo, formando un ciclo.

**Aplicaciones:**  
Rondas circulares, buffers, juegos o simulaciones repetitivas.  

**Métodos:**  
insertarCircular(), eliminarCircular(), recorrerCircular().

![Lista Circular](https://i.ytimg.com/vi/J9Arn_5Edhs/maxresdefault.jpg)

---

## ESTRUCTURAS NO LINEALES

### 1. Grafos

#### Definición
Un grafo es un conjunto de nodos (vértices) conectados mediante aristas (enlaces). Los grafos pueden ser dirigidos o no dirigidos.

#### Aplicaciones
- Redes sociales (conexiones entre personas).
- Mapas y rutas (Google Maps).
- Comunicación entre computadoras (redes).

#### Métodos Comunes
- agregarVertice()
- agregarArista()
- recorrerDFS() (búsqueda en profundidad)
- recorrerBFS() (búsqueda en anchura)
- buscarCamino()

![Grafos](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEihcmO5Tz5grEjSEq5DiZGNw1j7dn2MLrGn87fDpDAlf863Vm6mSbovR2Zk4ZxycIdsPur1Yp_h5B54mjWfLBuhlYO3fIlE0R8cpDZjwwZl3B8cv3kv4aN3uOnUK46HZAy0jukMMq2sAx53/s1600/grafoscola.gif)

---

### 2. Árboles

#### Definición
Un árbol es una estructura jerárquica de nodos donde cada nodo tiene un padre y cero o más hijos. El nodo superior se llama raíz.

#### Aplicaciones
- Sistemas de archivos (carpetas y subcarpetas).
- Árboles de decisión o búsqueda.
- Bases de datos y compiladores.

#### Métodos Comunes
- insertar()
- eliminar()
- buscar()
- recorridos: preorden, inorden, postorden.
- altura(): obtener la profundidad del árbol.

![Arboles](https://estructurasite.wordpress.com/wp-content/uploads/2016/04/arboles1.jpg)

---

## ESTRUCTURAS ABSTRACTAS

### 1. Conjunto (Set)

#### Definición
Un conjunto es una colección de elementos únicos, sin un orden específico.

#### Aplicaciones
- Eliminación de duplicados.
- Operaciones matemáticas (unión, intersección, diferencia).
- Gestión de etiquetas o categorías únicas.

#### Métodos Comunes
- add(): agregar elemento.
- remove(): eliminar elemento.
- union(), intersection(), difference(), subset().

![Conjunto](https://maritzacondori.wordpress.com/wp-content/uploads/2016/05/mapa.jpg)

---

### 2. Diccionario (Map o HashMap)

#### Definición
Un diccionario almacena pares clave–valor, donde cada clave es única y se usa para acceder a su valor asociado.

#### Aplicaciones
- Almacenamiento de configuraciones.
- Gestión de bases de datos pequeñas.
- Contadores de frecuencia (palabras, usuarios, visitas).

#### Métodos Comunes
- insertar(clave, valor)
- eliminar(clave)
- buscar(clave)
- keys(), values(), items()

![Diccionario](https://elenadaniela.weebly.com/uploads/2/3/8/3/23831776/header_images/1380154286.jpg)

---

## Conclusión
Las estructuras de datos permiten optimizar el manejo de la información según las necesidades del programa.  
Las lineales son ideales para datos secuenciales, las no lineales para relaciones complejas, y las abstractas para operaciones conceptuales.  
Comprender su uso y funcionamiento es esencial para diseñar algoritmos eficientes y escalables.
