# Implementación de Listas Circulares en C#

Este repositorio contiene la implementación de listas circulares y listas circulares dobles en C# como parte de la clase asincrónica para el curso de Algoritmos y Estructuras de Datos I (CE 1103) del Instituto Tecnológico de Costa Rica.

## Descripción

Este proyecto implementa dos tipos de estructuras de datos:

1. **Lista Circular Simple**: Una estructura de datos donde el último nodo apunta de vuelta al primer nodo, formando un círculo.
2. **Lista Circular Doble**: Una extensión de la lista circular donde cada nodo tiene referencia tanto al siguiente como al anterior, permitiendo el recorrido en ambas direcciones.

Ambas implementaciones incluyen las siguientes operaciones:
- Insertar al inicio
- Insertar al final
- Insertar en una posición indicada
- Eliminar al inicio
- Eliminar al final
- Eliminar en una posición indicada
- Obtener tamaño
- Representación de la lista como cadena de texto (ToString)

## Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

- **EstructurasDeDatos**: Biblioteca de clases que contiene las implementaciones de las listas circulares.
  - `CircularLinkedList.cs`: Implementación de la lista circular simple.
  - `DoubleCircularLinkedList.cs`: Implementación de la lista circular doble.

- **EstructurasDeDatosTests**: Proyecto de pruebas unitarias para validar el funcionamiento de las implementaciones.
  - `CircularLinkedListTests.cs`: Pruebas para la lista circular simple.
  - `DoubleCircularLinkedListTests.cs`: Pruebas para la lista circular doble.

## Requisitos

- .NET 8.0 o superior
- Visual Studio 2022 (recomendado para desarrollo)

## Cómo Ejecutar el Proyecto

### Usando Visual Studio 2022

1. Clone este repositorio en su máquina local:
   ```
   git clone https://github.com/Preko700/EstructurasDeDatos.git
   ```

2. Abra la solución `EstructurasDeDatos.sln` en Visual Studio 2022.

3. Compile la solución: 
   - Haga clic derecho en la solución en el Explorador de Soluciones.
   - Seleccione "Compilar solución" o presione F6.

4. Ejecute las pruebas unitarias:
   - En el menú superior, seleccione "Prueba" > "Ejecutar todas las pruebas".
   - O abra el Explorador de pruebas (menú "Prueba" > "Explorador de pruebas") y haga clic en "Ejecutar todas".

### Usando la Línea de Comandos

1. Clone este repositorio en su máquina local:
   ```
   git clone https://github.com/[usuario]/EstructurasDeDatos.git
   ```

2. Navegue al directorio del proyecto:
   ```
   cd EstructurasDeDatos
   ```

3. Compile el proyecto:
   ```
   dotnet build
   ```

4. Ejecute las pruebas:
   ```
   dotnet test
   ```

## Ejemplos de Uso

A continuación se muestran ejemplos básicos de cómo utilizar las listas implementadas:

```csharp
// Ejemplo con Lista Circular Simple
CircularLinkedList<int> listaSimple = new CircularLinkedList<int>();
listaSimple.InsertAtBeginning(10);
listaSimple.InsertAtEnd(20);
listaSimple.InsertAt(15, 1);
Console.WriteLine(listaSimple.ToString()); // Salida: "10, 15, 20"

// Ejemplo con Lista Circular Doble
DoubleCircularLinkedList<string> listaDoble = new DoubleCircularLinkedList<string>();
listaDoble.InsertAtBeginning("Primero");
listaDoble.InsertAtEnd("Último");
listaDoble.InsertAt("Medio", 1);
Console.WriteLine(listaDoble.ToString()); // Salida: "Primero, Medio, Último"
```

## Implementación de Pruebas Unitarias

Las pruebas unitarias verifican el correcto funcionamiento de todas las operaciones en ambas estructuras de datos. Incluyen casos de prueba para:

- Inserción en listas vacías y no vacías
- Eliminación en diferentes posiciones
- Manejo de excepciones para operaciones inválidas
- Validación del tamaño de la lista después de cada operación
- Verificación de la representación correcta como cadena de texto

## Autores

- Adrián Monge Mairena 

## Licencia

Este proyecto está licenciado bajo los términos del Apache License 2.0
