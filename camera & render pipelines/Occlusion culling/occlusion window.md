## Occlusion window


Before you begin, identify all of the GameObjects in your Scene that you would like to be Static Occluders (GameObjects that do not move, and that block the view of GameObjects that are behind them) and Static Occludees (GameObjects that do not move, and are occluded by Static Occluders). A GameObject can be both a Static Occluder and a Static Occludee.

Good candidates for Static Occluders are medium to large solid GameObjects, such as a wall or a building. To be a Static Occluder, a GameObject must:

- Have a Terrain or Mesh Renderercomponent
- Be opaque
- Not move at runtime



