## Positioning probes
You can set the size values directly or enable the size editing mode in the inspector and drag the sides of the box in the Scene view

>  The zones of the full set of probes should collectively **cover all areas of the scene** where a **reflective object** might pass. You should place probes close to any large objects in the scene that would be reflected noticeably. Areas around the centres and corners of walls are good candidate locations for probes.

> Smaller objects might require probes close by if they have a strong visual effect. For example, you would probably want the flames of a campfire to be reflected even if the object itself is small and otherwise insignificant.


By default, a probe’s zone of effect is **centred on its view point** but this may not be the ideal position for capturing the **reflection cubemap**. For example, the **probe zone** for a very high wall might **extend some distance from the wall** but you might want the reflection to be captured from **a point close to it** rather than the **zone’s centre**. You can optionally add an **offset** to **view point** using the **Box Offset property** (**ie, the offset is the position in the GameObject’s local space that the probe’s cubemap view is generated from**). Using this, you can easily **place the view point anywhere within the zone of effect** or indeed **outside the zone** altogether.


