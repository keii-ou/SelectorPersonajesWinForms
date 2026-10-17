# ⚔️ Selector de Personajes

Aplicación de escritorio para **Windows** desarrollada en **C# con Windows Forms (.NET 10)**. Permite navegar, elegir, añadir, editar, eliminar y ordenar personajes de fantasía mostrados como tarjetas, y además **compara el rendimiento de tres implementaciones de lista** (una lista enlazada propia y dos listas de .NET) mediante un benchmark integrado.

## Autores 👥

👤 Alexa Abigail Fraire Sandoval

👤 Elizabeth Anabely García Rivera

👤 Celeste Anyelique Garza Mauricio

👤 Rosembert Jared Ortiz Reyes

👤 Lia Kei Uchino Bonney 

## 📖 Descripción general

**Selector de Personajes** muestra una colección de personajes en una interfaz tipo carrusel: cada personaje aparece como una tarjeta con su imagen, nombre, especie, ataque, velocidad de ataque y nivel. El usuario navega con los botones `<` y `>` (o con las flechas del teclado), elige a su personaje favorito y puede gestionar la colección completa.

El propósito académico del proyecto es **demostrar el uso de estructuras de datos y su impacto en el rendimiento**. Toda la lógica de la aplicación trabaja contra una interfaz común (`IPersonasList`), por lo que la estructura subyacente puede cambiarse **en caliente** desde la interfaz sin perder los datos ni el orden actual.

---

## ✨ Características

- 🎴 **Navegación tipo carrusel** circular entre personajes, con una tarjeta extra al final para añadir uno nuevo.
- ⌨️ **Soporte de teclado**: flechas `←` y `→` para moverse entre personajes.
- ✅ **Selección de personaje**: el personaje elegido se muestra en la parte superior.
- ➕ **Alta, edición y baja** de personajes con formularios de validación y confirmaciones.
- 🔀 **Tres criterios de ordenamiento**: por nivel, por ataque y por velocidad.
- 🔁 **Cambio de estructura en tiempo real** entre tres implementaciones de lista, conservando los datos y el orden.
- 🖼️ **Imágenes por personaje** con una imagen *placeholder* generada por código cuando no hay archivo disponible.
- 📊 **Benchmark integrado** que mide diez operaciones sobre las tres listas con hasta 500,000 personajes, resalta el resultado más rápido y verifica que las tres listas produzcan resultados idénticos.
- 🧵 **Benchmark en segundo plano**: la interfaz no se congela mientras se ejecuta, y muestra el progreso.

---

## 🧰 Requisitos

| Requisito | Detalle |
|---|---|
| Sistema operativo | Windows (la app usa Windows Forms) |
| Framework | **.NET 10** (`net10.0-windows`) |
| Para ejecutar el `.exe` | .NET 10 Desktop Runtime (`Microsoft.WindowsDesktop.App 10.0.0`) |
| Para compilar | .NET 10 SDK, o Visual Studio con soporte para .NET 10 y la carga de trabajo *Desarrollo de escritorio de .NET* |

---

## 🚀 Instalación y ejecución

### Opción 1: ejecutar el binario ya compilado

El proyecto incluye una compilación en modo *Debug*:

```
SelectorPersonajes/bin/Debug/net10.0-windows/SelectorPersonajes.exe
```

Basta con tener instalado el .NET 10 Desktop Runtime y abrir el ejecutable.

### Opción 2: compilar desde la línea de comandos

```bash
cd SelectorPersonajes
dotnet build
dotnet run
```

### Opción 3: Visual Studio

1. Abre la carpeta del proyecto y carga el archivo `SelectorPersonajes.csproj`.
2. Presiona `F5` (depurar) o `Ctrl + F5` (ejecutar sin depurar).

---

## 🕹️ Guía de uso

### Ventana principal

La ventana tiene un tamaño de 500 × 730 px (mínimo 480 × 730) y se abre centrada en la pantalla. De arriba hacia abajo contiene:

| Zona | Descripción |
|---|---|
| **Barra superior** | Selector de tipo de lista (`Lista personalizada (nodos)`, `LinkedList<T>`, `List<T>`) y botón **Benchmark…** |
| **Personaje elegido** | Muestra `Personaje elegido: <nombre>` o `Ningún personaje elegido` |
| **Indicador de posición** | Formato `N / Total · Nombre de la lista`. El total incluye la tarjeta de «Añadir» |
| **Tarjeta del personaje** | Imagen, nombre, especie, ataque, velocidad de ataque y nivel, con botones `<` y `>` a los lados |
| **Acciones** | `Añadir`, `Editar`, `Eliminar` |
| **Ordenamiento** | `Nivel ↓`, `Ataque ↓`, `Velocidad ↑` |
| **Elegir personaje** | Botón grande en la parte inferior |

### Navegar

- Usa los botones `<` y `>` o las flechas `←` `→` del teclado.
- La navegación es **circular**: después del último personaje aparece la tarjeta **«★ Añadir nuevo personaje»** y, después de ella, se vuelve al primero.
- Las flechas del teclado se desactivan mientras el foco está en el desplegable de listas, para no interferir con su uso.

### Elegir un personaje

Con un personaje en pantalla, pulsa **Elegir personaje**. Su nombre aparecerá en la parte superior. Si ese personaje se elimina después, la selección se limpia automáticamente.

### Añadir un personaje

1. Navega hasta la tarjeta **«★ Añadir nuevo personaje»** (la última).
2. Pulsa **Añadir**. El botón solo está habilitado en esa tarjeta.
3. Completa el formulario y pulsa **Guardar**, luego confirma.
4. El nuevo personaje se agrega al final y la vista se posiciona sobre él.

### Editar un personaje

1. Ubícate en el personaje deseado y pulsa **Editar**.
2. Modifica los datos en el formulario y pulsa **Guardar**, luego confirma.
3. Los cambios se copian sobre el personaje existente (conserva su lugar en la lista).

### Eliminar un personaje

Pulsa **Eliminar** y confirma el cuadro de diálogo `¿Seguro que quieres eliminar a '<nombre>'?`. Si el personaje era el elegido, la selección se borra.

### Cambiar el tipo de lista

Selecciona otra opción en el desplegable **Lista**. La aplicación crea una lista del nuevo tipo, copia todos los personajes **en el mismo orden** y continúa trabajando con ella. El indicador de posición muestra la lista en uso.

### Ordenar

| Botón | Criterio |
|---|---|
| **Nivel ↓** | De mayor a menor nivel |
| **Ataque ↓** | De mayor a menor ataque |
| **Velocidad ↑** | De menor a mayor velocidad de ataque |

Tras ordenar, la vista **sigue al personaje que estabas viendo** y se reposiciona en su nueva ubicación.

### Formulario de edición

Ventana modal de 400 × 306 px, de tamaño fijo y centrada sobre la principal.

| Campo | Control | Reglas |
|---|---|---|
| **Nombre** | Cuadro de texto | Obligatorio. Se recortan los espacios al inicio y al final |
| **Especie** | Lista desplegable editable | Obligatoria. Opciones base: `Humano`, `Mago`, `Caballero`, `Arquero`, `Elfo`, `Enano`, `Orco`. También se puede escribir una especie propia |
| **Daño de ataque** | Numérico | Entero de 0 a 99,999. Valor inicial: 10 |
| **Velocidad de ataque** | Numérico | De 0.01 a 100 (valor por defecto del control), con 2 decimales y paso de 0.1. Valor inicial: 1.00 |
| **Nivel** | Numérico | Entero de 1 a 999. Valor inicial: 1 |

Si el nombre o la especie están vacíos se muestra una advertencia y el foco regresa al campo. Antes de guardar siempre se pide confirmación (`¿Guardar el nuevo personaje?` / `¿Guardar los cambios de este personaje?`).

---

## 🗂️ Estructura del proyecto

```
SelectorPersonajes/
├── Program.cs                  # Punto de entrada
├── Persona.cs                  # Modelo de datos y personajes por defecto
├── Listas.cs                   # Interfaz, criterios, fábrica y las 3 listas
├── MainForm.cs                 # Lógica de la ventana principal
├── MainForm.Designer.cs        # Diseño visual de la ventana principal
├── MainForm.resx
├── EditorForm.cs               # Lógica del formulario de alta/edición
├── EditorForm.Designer.cs      # Diseño visual del editor
├── EditorForm.resx
├── Benchmark.cs                # Motor del benchmark
├── BenchmarkForm.cs            # Lógica de la ventana del benchmark
├── BenchmarkForm.Designer.cs   # Diseño visual del benchmark
├── BenchmarkForm.resx
├── Properties/
│   ├── Resources.Designer.cs
│   └── Resources.resx
├── SelectorPersonajes.csproj   # Configuración del proyecto (.NET 10, WinForms)
├── SelectorPersonajes.csproj.user
├── bin/Debug/net10.0-windows/  # Compilación (exe, dll, pdb, configs)
└── obj/                        # Archivos intermedios de compilación
```

---

## 🏗️ Arquitectura y diseño

### Archivos y responsabilidades

#### `Program.cs`
Inicializa la configuración de la aplicación (`ApplicationConfiguration.Initialize()`) y lanza `MainForm`. Está marcado con `[STAThread]`, requisito de Windows Forms.

#### `Persona.cs`
Define la clase `Persona` (ver [Modelo de datos](#-modelo-de-datos)).

#### `Listas.cs`
Contiene la pieza central del diseño:

- **`ListType`**: enumeración con `Custom`, `LinkedList` y `List`.
- **`IPersonasList`**: contrato común de las tres listas.
- **`Criteria`**: comparadores estáticos para ordenar.
- **`ListFactory`**: crea listas y las convierte de un tipo a otro.
- **`Node`**, **`CustomList`**, **`ListaLinkedList`**, **`ListaNet`**: las tres implementaciones.

#### `MainForm.cs`
Mantiene el estado de la interfaz: la lista activa (`list`), el índice actual (`index`), el personaje elegido (`selected`) y la imagen *placeholder*. Reacciona a los eventos de botones y teclado, y centraliza el redibujado en el método `Refresh()`.

#### `EditorForm.cs`
Formulario modal. Recibe `null` para crear o un `Persona` para editar, valida los datos y expone el resultado en la propiedad `Result`.

#### `Benchmark.cs` y `BenchmarkForm.cs`
Motor de mediciones y ventana que lo presenta. Ver [Benchmark](#-benchmark).

### Interfaz `IPersonasList`

```csharp
public interface IPersonasList
{
    ListType Type { get; }
    string Name { get; }
    int Count { get; }
    Persona this[int indice] { get; }
    void Add(Persona p);
    void DeleteIn(int indice);
    void Clear();
    int Index(Persona p);
    IEnumerable<Persona> Iterate();
    void Order(Comparison<Persona> criteria);
}
```

| Miembro | Función |
|---|---|
| `Type` / `Name` | Tipo de lista y nombre legible que se muestra en la interfaz |
| `Count` | Número de personajes |
| `this[int]` | Acceso por índice (lanza `ArgumentOutOfRangeException` si está fuera de rango) |
| `Add` | Agrega al final |
| `DeleteIn` | Elimina el elemento en la posición indicada |
| `Clear` | Vacía la lista |
| `Index` | Devuelve la posición de una persona (comparación por **referencia**) o `-1` |
| `Iterate` | Recorre la lista en orden |
| `Order` | Ordena con un comparador |

### Patrones aplicados

- **Programación contra una interfaz**: la UI y el benchmark no saben qué lista usan.
- **Fábrica** (`ListFactory.Create`): decide qué implementación instanciar según `ListType`.
- **Conversión sin pérdida** (`ListFactory.Convert`): crea una lista nueva y copia los elementos en orden. Los objetos `Persona` se comparten por referencia, de modo que la selección actual se mantiene.

### Gestión de imágenes

`ShowImage` carga el archivo con `Image.FromFile` y lo **copia a un `Bitmap`** para no mantener el archivo bloqueado en disco. Se libera la imagen anterior al cambiar de personaje y todo se limpia al cerrar la ventana (`FormClosed`). Si la ruta no existe o el archivo no se puede leer, se muestra un *placeholder* de 300 × 300 dibujado por código (fondo gris claro, borde plateado y el texto «IMAGEN (placeholder)»).

---

## 🔗 Las tres implementaciones de lista

### 1. Lista personalizada (`CustomList`)

Una **lista doblemente enlazada circular** implementada desde cero con la clase `Node` (`Data`, `Next`, `Previous`).

- Un nodo recién creado se apunta a sí mismo en `Next` y `Previous`.
- Mantiene `head` (primer nodo), `count` y un **cursor** (`cursor` + `indexCursor`) que recuerda el último nodo visitado.
- **Acceso por índice optimizado**: en `NodeIn` calcula la distancia hacia adelante y hacia atrás respecto al cursor (aprovechando la circularidad) y recorre el camino más corto. Esto hace que navegar de un personaje al siguiente sea prácticamente inmediato, aunque el acceso aleatorio sigue siendo O(n).
- **Agregar**: inserta al final, enlazando con `head.Previous` y `head`, en O(1).
- **Eliminar**: reenlaza vecinos, mueve `head` si se borró la cabeza y reinicia el cursor en `head`.
- **Ordenar**: copia los datos a un arreglo, usa `Array.Sort` y reescribe el `Data` de cada nodo en orden (no se recrean nodos).

### 2. `LinkedList<T>` de .NET (`ListaLinkedList`)

Envuelve `System.Collections.Generic.LinkedList<Persona>`. Como esa clase **no es circular**, la envoltura aplica la misma técnica del cursor y, al llegar a un extremo, salta con `Next ?? First` o `Previous ?? Last`. Eliminar reinicia el cursor. Ordenar también pasa por un arreglo.

### 3. `List<T>` de .NET (`ListaNet`)

Envuelve `System.Collections.Generic.List<Persona>` (arreglo dinámico). Acceso por índice en O(1) y ordenamiento con `List.Sort`. Eliminar en la posición 0 es O(n) porque desplaza los elementos.

### Resumen comparativo

| Operación | Personalizada | `LinkedList<T>` | `List<T>` |
|---|---|---|---|
| Agregar al final | O(1) | O(1) | O(1) amortizado |
| Acceso por índice | O(n), optimizado con cursor | O(n), optimizado con cursor | O(1) |
| Recorrer todo | O(n) | O(n) | O(n) |
| Eliminar al inicio | O(1) tras ubicar el nodo | O(1) tras ubicar el nodo | O(n) |
| Ordenar | O(n log n) | O(n log n) | O(n log n) |

> La tabla muestra la teoría; el benchmark integrado permite comprobarlo en la práctica.

---

## 🔀 Criterios de ordenamiento

Definidos en la clase estática `Criteria`:

| Criterio | Orden |
|---|---|
| `NivelDesc` | Nivel, de mayor a menor |
| `DanoDesc` | Ataque, de mayor a menor |
| `VelocidadAsc` | Velocidad de ataque, de menor a mayor |

Todos usan un **desempate por nombre** (`string.CompareOrdinal`). Esto garantiza que, ante valores iguales, las tres listas produzcan **exactamente el mismo orden**, requisito necesario para que el benchmark pueda verificar que los resultados coinciden.

---

## 📊 Benchmark

Se abre con el botón **Benchmark…** de la ventana principal. Toma como base los personajes actuales de la lista y genera miles de personajes sintéticos para medir el rendimiento de cada estructura.

### Parámetros

| Parámetro | Rango | Valor por defecto | Paso |
|---|---|---|---|
| **Cantidad de personajes** | 1,000 – 500,000 | 100,000 | 10,000 |
| **Repeticiones** | 1 – 10 | 3 | 1 |

### Generación de datos

Los personajes se derivan de los actuales repitiéndolos de forma cíclica (si la lista está vacía se usan los personajes por defecto). Para el personaje número `i` se calcula `ciclo = i / cantidadBase` y se obtienen:

- **Nombre**: `"<nombre base> #<i+1>"`
- **Especie**: la del personaje base
- **Ataque**: `ataque base + (ciclo % 50) × 2`
- **Velocidad**: `velocidad base + (ciclo % 10) × 0.05` (redondeada a 2 decimales)
- **Nivel**: `nivel base + ciclo % 50`

### Operaciones medidas

Para cada tipo de lista se ejecutan estas **10 operaciones**, cronometradas con `Stopwatch`:

| # | Operación | Descripción |
|---|---|---|
| 1 | **Insertar personajes** | Agrega todos los personajes generados |
| 2 | **Ataque total y nivel promedio** | Recorre la lista sumando ataque y nivel |
| 3 | **DPS total (daño × velocidad)** | Suma el DPS de cada personaje |
| 4 | **Persona con mayor DPS** | Busca el máximo recorriendo la lista |
| 5 | **Conteo por especie** | Cuenta personajes por especie en un diccionario |
| 6 | **Acceso por índice ×N** | `N = min(500, cantidad)` accesos aleatorios, con un salto basado en la proporción áurea (0.618) para recorrer toda la lista |
| 7 | **Ordenar por nivel ↓** | Ordena con `NivelDesc` |
| 8 | **Ordenar por daño ↓** | Ordena con `DanoDesc` |
| 9 | **Ordenar por velocidad ↑** | Ordena con `VelocidadAsc` |
| 10 | **Eliminar los primeros K** | `K = max(1, min(1000, cantidad / 10))` eliminaciones en el índice 0 |

### Metodología

- **Calentamiento (JIT)**: la pasada 0 no se promedia, para evitar que la compilación JIT distorsione las mediciones.
- **Recolección de basura**: antes de cada pasada se ejecuta `GC.Collect()` y `GC.WaitForPendingFinalizers()`.
- **Promedio**: se reportan los milisegundos promedio de las repeticiones elegidas.
- **Medición limpia**: solo se cronometra la acción; el texto de la «estadística calculada» se arma fuera del cronómetro.
- **Ejecución asíncrona**: corre con `Task.Run` y reporta el progreso (`calentamiento…`, `pasada 2/3…`) a la interfaz mediante `BeginInvoke`. Mientras se ejecuta, los controles se deshabilitan.

### Resultados en pantalla

Una tabla de solo lectura con las columnas:

| Columna | Contenido |
|---|---|
| **Operación** | Nombre de la operación |
| **Custom (ms)** | Tiempo de la lista personalizada |
| **LinkedList<T> (ms)** | Tiempo de `LinkedList<T>` |
| **List<T> (ms)** | Tiempo de `List<T>` |
| **Estadística calculada** | Resultado de la operación (totales, promedios, mejor DPS, etc.) |

- 🟩 La celda **más rápida** de cada fila se resalta en **verde**.
- Una fila final **TOTAL** (en negritas) suma los tiempos de cada lista.
- Un mensaje de **verificación** confirma si las tres listas produjeron resultados idénticos:
  - 🟢 *«Las tres listas produjeron exactamente los mismos resultados.»*
  - 🔴 *«Los resultados difieren entre listas (revisar).»*

---

## 🧬 Modelo de datos

Clase `Persona`:

| Propiedad | Tipo | Descripción |
|---|---|---|
| `Name` | `string` | Nombre del personaje |
| `Species` | `string` | Especie |
| `Attack` | `int` | Daño de ataque |
| `AtackSpeed` | `double` | Velocidad de ataque |
| `Level` | `int` | Nivel |
| `ImagePath` | `string?` | Ruta a la imagen (opcional) |
| `Dps` | `double` (calculada) | `Attack × AtackSpeed` |

Otros miembros:

- `EspeciesBase`: arreglo con las especies sugeridas en el editor.
- `CopyFrom(Persona otro)`: copia todos los campos desde otro personaje (se usa al editar).
- `Default()`: devuelve la lista inicial de personajes.

### Personajes iniciales

| Nombre | Especie | Ataque | Velocidad | Nivel |
|---|---|---|---|---|
| Arthur | Caballero | 45 | 1.2 | 12 |
| Merlín | Mago | 70 | 0.8 | 20 |
| Azriel | Arquera | 38 | 2.5 | 15 |
| Thorin | Enano | 55 | 1.0 | 18 |
| Arlene | Humana | 25 | 1.5 | 5 |

---

## ⚠️ Limitaciones conocidas

- **Rutas de imágenes fijas**: los personajes iniciales apuntan a rutas absolutas de la computadora de desarrollo (`C:\Users\usuario\OneDrive - Instituto Tecnológico Superior de Monclova\Imágenes\...`). En otro equipo esas imágenes no existirán y se mostrará el *placeholder*. Para verlas, edita las rutas en el método `Persona.Default()` dentro de `Persona.cs` o cambia las imágenes por archivos locales.
- **Sin selector de imagen**: el editor no permite elegir una imagen; al crear un personaje nuevo queda sin imagen (se ve el *placeholder*) y al editar se conserva la que ya tenía.
- **Sin persistencia**: los datos viven solo en memoria. Al cerrar la aplicación, los cambios se pierden y se restauran los personajes iniciales.
- **Nombre de propiedad**: la propiedad `AtackSpeed` está escrita con una sola «t» (en lugar de `AttackSpeed`) y se usa así en todo el código.
- **Mezcla de idiomas**: parte del código y algunos textos de la interfaz combinan español e inglés (por ejemplo `Level ↓` y `Attack ↓` en los botones de orden).

---

## 🛠️ Tecnologías

- **Lenguaje**: C# (con *nullable reference types* e *implicit usings* habilitados)
- **Plataforma**: .NET 10 (`net10.0-windows`)
- **Interfaz**: Windows Forms (`TableLayoutPanel`, `DataGridView`, `NumericUpDown`, `ComboBox`, `PictureBox`)
- **Conceptos de programación**: listas doblemente enlazadas circulares, interfaces, patrón fábrica, delegados (`Comparison<T>`), iteradores (`yield return`), programación asíncrona (`async`/`await`, `Task.Run`) y medición de rendimiento con `Stopwatch`
