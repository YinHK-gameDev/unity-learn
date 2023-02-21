// Calculate the size of the Frustum at a Given Distance from the Camera
/* 
  A cross-section of the view frustum at a certain distance from the camera
 defines a rectangle in world space that frames the visible area. It is sometimes useful to calculate the size of this rectangle at a given distance, or find the distance where the rectangle is a given size. For example, if a moving camera needs to keep an object (such as the player) completely in shot at all times then it must not get so close that part of that object is cut off.
 */



//The height of the frustum at a given distance (both in world units) can be obtained with the following formula:
var frustumHeight = 2.0f * distance * Mathf.Tan(camera.fieldOfView * 0.5f * Mathf.Deg2Rad);

//…and the process can be reversed to calculate the distance required to give a specified frustum height:
var distance = frustumHeight * 0.5f / Mathf.Tan(camera.fieldOfView * 0.5f * Mathf.Deg2Rad);

//It is also possible to calculate the FOV angle when the height and distance are known:
var cameraFieldOfView = 2.0f * Mathf.Atan(frustumHeight * 0.5f / distance) * Mathf.Rad2Deg;


//Each of these calculations involves the height of the frustum but this can be obtained from the width (and vice versa) very easily:
var frustumWidth = frustumHeight * camera.aspect;
var frustumHeight = frustumWidth / camera.aspect;
