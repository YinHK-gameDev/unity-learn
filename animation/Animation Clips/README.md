## Animation Clips
Animation Clips are one of the core elements to Unity’s animation system. Unity supports importing animation from external sources, and offers the ability to create animation clips
from scratch within the editor using the Animation window.
 
### nimation from External Sources

Animation clips imported from external sources could include:

- Humanoid animations captured at a motion capture studio
- Animations created from scratch by an artist in an external 3D application (such as Autodesk® 3ds Max® or Autodesk® Maya®)
- Animation sets from 3rd-party libraries (eg, from Unity’s asset store)
- Multiple clips cut and sliced from a single imported timeline.

### Creating a new Animation Clip

To create a new Animation Clip, select a GameObject in your Scene, and open the Animation Window (top menu:) **Window > Animation > Animation**.

If the GameObject does not yet have any Animation Clips assigned, the "**Create**" button appears in the centre of the Animation Window timeline area

When you save this new empty Animation Clip, Unity does the following:

- Creates a new Animator Controller Asset
- Adds the new clip into the Animator Controller as the default state
- Adds an Animator Component to the GameObject that you are applying animation to
- Assigns the new Animator Controller to the Animator Component
- 
All the required elements of the animation system are now set up, and you can begin animating the GameObject.


