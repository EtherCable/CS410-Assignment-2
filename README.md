# CS410-Assignment-2

Authors: Alexandr, Chase, Etienne, Jordan
Professor Wills
Spring, 2024

## 1. [10] Get this downloaded and running:
https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-learn-3d-beginner-complete-project-urp-143846

Implemented by: Etienne

## 2. [20] Add at least one gameplay element that uses a dot product in some way (e.g., calculate length, distance, angle, facing direction).
Implmented by:

## 3. [20] Add at least one gameplay element that uses linear interpolation in some way (e.g., calculate intermediate position, orientation, color).
Implmented by:

## 4. [20] Add at least one new particle effect and trigger(s).
Implmented by:

## 5. [20] Add at least one new sound effect and trigger(s).
Implemented by: Etienne

The sound effect is played when the player walks through an invisible trigger. The trigger is simply a plane GameOjbect thinned out, made invisible, with no collider. This has been placed in the door ways of certain rooms. Attached is a script that triggers an Audio Source. This audio source is attached to the player and moves around with them. The audio source plays a WAV file. The script disables the GameObject after the plane has been collided with to prevent the sounds from playing repeatedly. The trigger will only execute if a GameObject with the "Player" tag collides with it. This is so only certain entities can trigger the sound. John Lemon has been given the "Player" tag to so they can trigger the sound.


## 6. [10] Create a GitHub repo for your project. In the repo readme, describe the use of the dot product, linear interpolation, particle effect, and sound effect and how to make these happen in game. Also include the names of your team members and the contributions from each team member.

Implemented by: Etienne
