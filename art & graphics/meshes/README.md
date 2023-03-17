## Mesh

A mesh is a collection of data that describes a shape. In Unity, you use meshes in the following ways:

- In graphics, you use meshes together with materials; meshes describe the shape of an object that the GPU renders, and materials describe the appearance of its surface.
- In physics, you can use a mesh to determine the shape of a colliderAn invisible shape that is used to handle physical collisions for an object. A collider doesn’t need to be exactly the same shape as the object’s mesh - a rough approximation is often more efficient and indistinguishable in gameplay. More info

### What is mesh in modeling?
A mesh model consists of **vertices, edges, and faces that use polygonal representation, including triangles and quadrilaterals, to define a 3D shape**. Unlike solid models, mesh has no mass properties. However, as with 3D solids, you can create primitive mesh forms such as boxes, cones, and pyramids.

A 3D mesh is the structural build of a 3D model consisting of polygons. 3D meshes use reference points in X, Y and Z axes to define shapes with height, width and depth.

The polygons used are typically quadrangles or triangles; these geometric shapes can be further broken down into vertices in X, Y, Z coordinates and lines.

### Deformable meshes
(Deformable means that **capable of being reshaped**)

In addition to regular meshes, Unity also supports **deformable meshes**.

**Deformable meshes** fall into the following categories:

- **Skinned meshes**: \
  These meshes work with **additional data** called **bones**. **Bones** form a structure called a **skeleton** (also called a **rig**, or **joint** hierarchy), and the **skinned mesh** contains data that allows it to deform in a realistic way when the skeleton moves. You usually use skinned meshes for skeletal animation with Unity’s Animation features, but you can also use them with Rigidbody components to create “ragdoll” effects.
- Meshes with blend shapes: These meshes contain data called blend shapes. Blend shapes describe versions of the mesh that are deformed into different shapes, which Unity interpolates between. You use blend shapes for morph target animation, which is a common technique for facial animation.
- Meshes that work with a Cloth component component for realistic fabric simulation.




https://docs.unity3d.com/Manual/mesh-introduction.html
