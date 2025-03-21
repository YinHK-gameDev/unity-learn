## Mask map


### HDRP Mask Map

In Unity’s HDRP/Lit Shader, you don't directly assign Metallic and Roughness maps separately. Instead, HDRP expects a Mask Map, which packs multiple textures into one.


Unity’s Mask Map stores multiple textures in different channels:

| Channel |	Texture Type |
| - | - |
| R (Red)	| Metallic Map |
| G (Green)	| Ambient Occlusion (AO) Map |
| B (Blue) | Smoothness Map (Inverted Roughness) |
| A (Alpha)	| Height/Displacement Map (Optional) |


**Important:** \
- **Metallic Map** → **R channel**
- **Roughness Map** (from Blender) → **Inverted & placed in B channel** (Unity uses Smoothness, which is the inverse of Roughness).




