# Sistema de Control de Producción — IES21

Trabajo práctico de **Laboratorio de Programación 1**, desarrollado en **C# Windows Forms**, Visual Studio 2017 y .NET Framework 4.7.2.

## Ejecutar (sin Visual Studio)

1. Descargá y extraé el proyecto.
2. Dentro del proyecto extraído, abrí `SistemaControlProduccion/bin/Debug/`.
3. Hacé doble clic en **`SistemaControlProduccion.exe`**.

Ruta desde la raíz del proyecto extraído: `SistemaControlProduccion/bin/Debug/SistemaControlProduccion.exe`.

Necesitás Windows y **.NET Framework 4.7.2**. Conservá `.exe.config` junto al ejecutable. Si no encontrás `bin/Debug`, compilá desde Visual Studio.

## Abrir el código y compilar

Abrí `SistemaControlProduccion.sln` en Visual Studio 2017 (o una versión compatible). Presioná **F5** para ejecutar, o **Ctrl + Shift + B** para compilar.

## Uso

1. Primero elegí **Sistema → Carga Automática de Datos**.
2. Después usá **Producción → Consultar cantidad producida de un empleado** para ver la producción por máquina.
3. Usá **Producción → Listar total producido en cada máquina** para ver los totales.
4. **Sistema → Acerca de…** muestra datos académicos; **Salir** cierra el programa.

La carga genera números aleatorios entre 0 y 100, que se conservan solo mientras está abierto el programa.
