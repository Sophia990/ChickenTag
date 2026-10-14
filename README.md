### Chicken Tag

Chase and run away from other chickens in this game of tag - just make sure you're not it when the timer ends!

Play the game: https://sophia990.itch.io/chicken-tag

**Technical Details**

Engine: Unity 2022.3.14f1 (LTS)

Platforms: Browser

**Project Description**

Chicken Tag is a student project that I made over seven days whilst completing work experience at Fruity Systems. I am new to both Unity and C#, so I used this project as a way to begin developing my knowledge of these.

Some of the skills I learnt include how to use and control UI elements, such as buttons; I created a main menu for my game, using a script to control the functions of the buttons and a scriptable object to control their colours. 

In addition to this, I learnt about AI navigation in Unity, which I used to help control the movement of the NPCs. I used the rigidbody and box collider components to detect collisions, and another script to control what happens when a collision is detected.

I also learnt how to create prefabs, as I made an NPC prefab in order to be able to make multiple NPCs easily without having to repeat changes I make to one on all of them. 

Another skill I developed was debugging, using Debug.Log in scripts, and by creating a specific debugger script, in which I used gizmos to show if a chicken was it and if a chicken was frozen in place.

Although I was given the project of making a game of tag, I made various design choices within the game. I chose to use chickens as characters for aesthetic purposes, and used a different coloured chicken for the player so that they can be easily differentiated from the NPCs. I also wanted the chicken who is it to be easy to spot, so I added a blue circle underneath them, which is simple and unobtrusive, but easy enough to understand.

Another choice that I made was to not have the directional light directly above the scene, but as an angle, as having some shadows makes the scene more interesting visually. With regards to game mechanics, I made chickens that are it slower than those that aren’t to make it harder to tag another chicken, as well as making the player slower that NPCs at all times, to make the game a little harder. I also chose to have 6 NPCs, as I wanted to include a group of them, but not too many, as the more NPCs there were, the easier the game became, since the NPCs would just chase each other rather than the player.
