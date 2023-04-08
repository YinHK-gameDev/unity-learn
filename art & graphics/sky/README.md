## Sky
### Sky and render pipelines
The sky solutions you can use depend on which render pipeline your Project uses.
 
 
| Render pipeline | Sky Solution |
| --- | --- |
| Built-in Render Pipeline | The Built-in Render Pipeline uses a skybox Material to define a sky for Cameras to draw. You can specify the sky on a per-Scene basis and also override the sky for an individual Camera.• For information on how to set the sky on a per-Scene basis, see the Lighting window documentation.• For information on how to override the sky for a specific Camera, see the Skybox component documentation. |
| Universal Render Pipeline (URP) | URP uses the same sky solution as the Built-in Render Pipeline and allows you to specify the sky on a per-Scene basis and override the sky for an individual Camera.• For information on how to set the sky on a per-Scene basis, see the Lighting window documentation.• For information on how to override the sky for a specific Camera, see the Skybox component documentation. |
| High Definition Render Pipeline (HDRP) | HDRP includes its own sky solution that uses the Volume system. Each Volume can include an override to specify a type of sky to draw. Each Camera interpolates between the sky settings for every Volume that affects it and draws the result.For information on how to create a sky in HDRP, see the Visual Environment documentation. |

