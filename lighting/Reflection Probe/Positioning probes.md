## Positioning probes
You can set the size values directly or enable the size editing mode in the inspector and drag the sides of the box in the Scene view

>  The zones of the full set of probes should collectively **cover all areas of the scene** where a **reflective object** might pass. You should place probes close to any large objects in the scene that would be reflected noticeably. Areas around the centres and corners of walls are good candidate locations for probes.

> Smaller objects might require probes close by if they have a strong visual effect. For example, you would probably want the flames of a campfire to be reflected even if the object itself is small and otherwise insignificant.


By default, a probe’s zone of effect is **centred on its view point** but this may not be the ideal position for capturing the **reflection cubemap**. For example, the **probe zone** for a very high wall might **extend some distance from the wall** but you might want the reflection to be captured from **a point close to it** rather than the **zone’s centre**. You can optionally add an **offset** to **view point** using the **Box Offset property** (**ie, the offset is the position in the GameObject’s local space that the probe’s cubemap view is generated from**). Using this, you can easily **place the view point anywhere within the zone of effect** or indeed **outside the zone** altogether.

### Overlapping probe zones

By default, Unity calculates the intersection between the reflective object’s bounding box and each of the overlapping probe zones; the zone which has the **largest volume of intersection with the bounding box** is the one that will be selected.

> You can modify the calculation using the probes’ **Importance properties**. Probes with a **higher importance value** have **priority** over those of lower importance within overlap zones. This is useful, say, if you have a small probe zone that is contained completely inside a larger zone

