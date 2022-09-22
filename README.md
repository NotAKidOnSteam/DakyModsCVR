## Fork of dakyneko's mod repo for my personal edits.
This fork will most likely only include changes targeted towards their Action Menu mod.

## My Personal Changes

### ActionMenu.cs
* mouse is handled as clamped joystick instead of using absolute mouse position

* instead of disabling all movement while menu is open, postfix input manager to 0-out required input only 
  * (allows movement while menu is open for both VR and Desktop)

* less harmony patches needed (believe 4 removed..?)

* hooked unused chilloutvr steamvr binding so left/right hand distinction is possible

* one-handed controls option for VR

* menu reposition in desktop takes screen aspect ratio into account, allowing to reach far left/right - vr is unaffected

* hooked main camera prerender() to update menu anchor position to prevent tearing or artifacts during fast movements

* multiplied base scale & canvas size by 1.5x to give the menu more room to render text

### index.js
* radial widget now can reach 100%

* joystick2d widget yaxis result is no longer inverted

* on desktop, widgets will center the joystick and wait for you to leave the deadzone before accepting input

* increased widget deadzone from 0.5f to 0.8f

* joystick2d triangles size are set on start/widget open

### index.css
* center objects to new canvas size

# License
With the following exceptions, all mods here are provided under the terms of [GNU GPLv3 license](LICENSE)
