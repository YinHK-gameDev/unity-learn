## Unity 2D

### Initial setup for 2D games

1. Install Unity version 2019 LTS or a later version; see Installing Unity.
2. Create a new project with the 2D template.
3. In the Package Manager, install the latest URP package version; see Installing the Universal Render Pipeline into an existing Project.
4. Set up a 2D Renderer; see the 2D Renderer Setup steps.
5. Install any optional packages you need; see Installing packages.


### Useful package for developing Unity 2D games

Most packages you need to make a 2D game in Unity are included in the Unity Editor. The following table lists the packages included by default when you choose the 2D template:


| Package | Description |
| --- | --- |
| 2D Animation | 2D Animation provides the necessary tooling and runtime components for applying skeletal animation to your Sprites. |
| 2D Pixel Perfect | The 2D Pixel Perfect package contains the Pixel Perfect Camera component, which ensures your pixel art remains crisp and clear at different resolutions, and stable in motion. |
| 2D PSD Importer | The 2D PSD Importer package allows you to import multilayered PSD files from Photoshop. You can use this for your Sprites, or to rig your characters. |
| 2D Sprite | The Sprite Editor provides an in-Editor environment to create and edit Sprite assets. Sprite Editor lets you add custom behavior for editing Sprite-related data. |
| 2D SpriteShape | 2D Sprite Shape allows you to create organic shapes and terrains, similar to a vector drawing tool. For example, you can choose the fill texture and border Sprites. |
| 2D Tilemap Editor | 2D Tilemap Editor allows you to create grid-based worlds with square, hexagonal or isometric tiles. Add your Tiles to the Tile Palette, and paint and fill Tile Grids using different settings and brushes. Extra tools let you add smart drawing, randomization or animation to the Tile assets. |


**Optional packages:**
| Package | Description |
| --- | --- |
| Shader Graph | Shader Graph lets you build your shaders visually. |
| Cinemachine | The Cinemachine package is a suite of modules that provide advanced functionality for operating the Unity Camera. |
| 2D Tilemap Extras | The 2D Tilemap Extras package contains reusable 2D and Tilemap Editor scripts that you can use for your own Projects. |


### Sprites
Sprites are 2D graphic objects. You use Sprites for all types of 2D games. For example, you can import an image of your main character as a Sprite.

You can also use a collection of Sprites to build a character. This allows you greater control over the movement and animation of your characters.

### Sprite Renderer
The Sprite Renderer component renders the Sprite and controls how it looks in a scene.

Use the Sprite Renderer component to render your Sprites. For example, you can use the Sprite Renderer to change the color and opacity of a Sprite.


### Sprite Atlas

You can use a Sprite Atlas to consolidate several Textures into a single combined Texture. This optimizes your game and saves memory. For example, you can add all your Sprites associated with a particular character or purpose to a Sprite Atlas.
 
 
