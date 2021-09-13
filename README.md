# Color Thief Unity
A code for grabbing the color palette from an image.

Original Project [Color Thief](https://github.com/lokesh/color-thief) by lokesh  
Ported Project of [Color Thief .NET](https://github.com/KSemenenko/ColorThief) by KSemenenko   
[Unity Version](https://github.com/chiutse/ColorThief) by chiutse  
[Unity Package Manager version](https://github.com/needle-tools/ColorThief.git) by hybridherbst  

## How To Use
Dominant Color
```cs
var dominant = new ColorThief.ColorThief();
Color color = dominant.GetColor(texture).UnityColor;
```

Palette Color
```cs
var palette = new ColorThief.ColorThief();
List<ColorThief.QuantizedColor> colors = palette.GetPalette(texture, paletteColors.Length);
```
