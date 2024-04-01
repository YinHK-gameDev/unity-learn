## Overlapping probe zones

It would be very difficult to position the zones of neighbouring reflection probes without them overlapping and fortunately, it is not necessary to do so. However, this leaves the issue of choosing which probe to use in the overlap areas. By default, Unity calculates the intersection between the reflective object’s bounding box and each of the overlapping probe zones; the zone which has the largest volume of intersection with the bounding box is the one that will be selected.


![](./ProbeZoneOverlap.svg)


Probe A is selected since its intersection with the object is larger
You can modify the calculation using the probes’ Importance properties. Probes with a higher importance value have priority over those of lower importance within overlap zones. This is useful, say, if you have a small probe zone that is contained completely inside a larger zone (ie, the intersection of the character’s bounding box with the enclosing zone might always be larger and so the small zone would never be used).

### ref 
https://docs.unity3d.com/Manual/UsingReflectionProbes.html

