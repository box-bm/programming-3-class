# Pseudcodigo de las pilas y colas

```ps
// Inicialización de la pila vacía
pila = []

// Agregar elemento a la pila
elemento = 42
pila.PUSH(elemento)

// Verificar si la pila está vacía
SI pila.LENGTH ES IGUAL A 0 ENTONCES
  PRINT("La pila está vacía")
SINO
  PRINT("La pila no está vacía")

// Quitar y mostrar el elemento superior si la pila no está vacía
SI pila.LENGTH ES MAYOR A 0 ENTONCES
  elementoQuitado = pila.POP()
  PRINT("Elemento quitado: " + elementoQuitado)
SINO
  PRINT("La pila está vacía")
```
