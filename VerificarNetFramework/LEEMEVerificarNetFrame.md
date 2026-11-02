# Verificar .NET Framework antes de ejecutar la aplicación

Esta guía acompaña al conversor de temperaturas desarrollado en C# con Windows Forms.

## Requisitos

- Windows con **.NET Framework 4.7.2** o una versión posterior compatible de la misma familia, como **4.8 o 4.8.1**.
- No es necesario tener Visual Studio para ejecutar la aplicación compilada.
- Tener instalado .NET 8, .NET 9 u otra versión de .NET moderno no reemplaza el requisito de .NET Framework.

## 1. Consultar la instalación desde CMD

1. Presioná **Windows + R**.
2. Escribí `cmd` y presioná **Enter**.
3. Copiá el siguiente comando, pegalo en la ventana de CMD con clic derecho y presioná **Enter**:

```bat
reg query "HKLM\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" /v Release
```

Este comando solamente consulta información del registro de Windows; no modifica el equipo.

El resultado debería contener una línea similar a esta:

```text
Release    REG_DWORD    0x82718
```

El número que sigue a `REG_DWORD` está expresado en hexadecimal. El resultado puede ser diferente en tu equipo.

## 2. Convertir el resultado de HEX a DEC

1. Abrí la **Calculadora de Windows**.
2. En su menú, seleccioná el modo **Programador**.
3. Presioná **CE** para borrar cualquier valor anterior.
4. **Seleccioná HEX antes de ingresar el número.**
5. Escribí el valor que devolvió CMD, **sin el prefijo `0x`**. Por ejemplo: `82718`.
6. Consultá la fila **DEC**, que muestra automáticamente el equivalente decimal. **No hace falta presionar `=`.**

**Ejemplo:** `0x82718` en hexadecimal equivale a **534296** en decimal. La calculadora puede mostrarlo como `534.296`, con separador de miles.

> Si ingresás el número con DEC seleccionado, la calculadora lo interpretará como decimal y la conversión será incorrecta. Borrá el valor, seleccioná HEX y volvé a ingresarlo.

## 3. Interpretar el valor decimal

Microsoft establece los siguientes umbrales mínimos. Compará de mayor a menor:

| Valor decimal de Release | Versión mínima detectada |
|---|---|
| 533320 o superior | .NET Framework 4.8.1 o posterior |
| 528040 a 533319 | .NET Framework 4.8 |
| 461808 a 528039 | .NET Framework 4.7.2 |
| Inferior a 461808 | No cumple el requisito mínimo de esta aplicación |

**Si el resultado es igual o superior a 461808, el equipo cumple el requisito de .NET Framework de esta aplicación.**

En el ejemplo, **534296** supera el umbral de **533320**, por lo que se detecta **.NET Framework 4.8.1 o posterior**.

Si el comando indica que no encuentra la clave o el valor, no se pudo confirmar el requisito mediante esta consulta. Si muestra otro error, como acceso denegado, ese error no permite determinar la versión instalada.

Podés consultar e instalar una versión compatible con tu Windows desde el [sitio oficial de Microsoft](https://dotnet.microsoft.com/es-es/download/dotnet-framework).

## 4. Probar el programa compilado

1. Descargá el archivo RAR de la aplicación.
2. Extraé **todo su contenido** en una carpeta con una herramienta compatible con RAR.
3. Abrí la carpeta extraída y ejecutá el archivo **`.exe`** de la aplicación.
4. Mantené juntos los archivos incluidos en el paquete.
5. Comprobá una conversión conocida: **0 °C = 32 °F = 273,15 K**.

La consulta verifica el requisito de .NET Framework. El funcionamiento completo también depende de que el paquete incluya los archivos necesarios y de que la aplicación funcione correctamente.

## Referencia oficial

[Microsoft: determinar qué versiones de .NET Framework están instaladas](https://learn.microsoft.com/es-es/dotnet/framework/install/how-to-determine-which-versions-are-installed).
