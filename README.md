# CS410-Assignment-2

Authors: Alexandr, Chase, Etienne, Jordan

Professor Wills

Spring, 2024

## 1. [10] Get this downloaded and running:
https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-learn-3d-beginner-complete-project-urp-143846

Implemented by: Etienne

## 2. [20] Add at least one gameplay element that uses a dot product in some way (e.g., calculate length, distance, angle, facing direction).
Implemented by: Jordan Reedy

The dot product is used to calculate 2 things: first, how close the player is to the clock that provides the tooltip, and second to check whether the forward of the player is perpendicular to the forward of the clock. When the character is close enough to the clock, which is placed in the middle of the room and next to particles so that the player will investigate it, a tooltip appears that gives the player some instructions for the game. There was an unfortunate moment where the programmer for this task realized that the forward of the clock is somehow projected out the side, so the calculations were altered to check for perpendicular forwards, so the clock will ring out it's warning while the player walks directly away from it as well. The programmer made this a feature and not a bug, letting the message ring out after the character increases the creep factor.

## 3. [20] Add at least one gameplay element that uses linear interpolation in some way (e.g., calculate intermediate position, orientation, color).
Implemented by: Chase Maslow

Ghosts now have a point light that illuminates the area they can see. It is normally white, but as John Lemon approaches it turns red, showing the player how close they are to getting caught. The reddening of the light's color is calculated by Color.Lerp().

## 4. [20] Add at least one new particle effect and trigger(s).
Implemented by: Alexandr Iapara
- Crying Particle effect following player model.
- Spinning Star with yellow particles that vanishes when player collides with it.
- Red trail following the player and slowly vanishing/shortening over time.

## 5. [20] Add at least one new sound effect and trigger(s).
Implemented by: Etienne

The sound effect is played when the player walks through an invisible trigger. The trigger is simply a plane GameOjbect thinned out, made invisible, with no collider. This has been placed in the door ways of certain rooms. Attached is a script that triggers an Audio Source. This audio source is attached to the player and moves around with them. The audio source plays a WAV file. The script disables the GameObject after the plane has been collided with to prevent the sounds from playing repeatedly. The trigger will only execute if a GameObject with the "Player" tag collides with it. This is so only certain entities can trigger the sound. John Lemon has been given the "Player" tag to so they can trigger the sound.


## 6. [10] Create a GitHub repo for your project. In the repo readme, describe the use of the dot product, linear interpolation, particle effect, and sound effect and how to make these happen in game. Also include the names of your team members and the contributions from each team member.

Implemented by: Etienne
