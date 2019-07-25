# XP_Level
A simple Xp and Level system for your player in Unity

***

## XP_Lvl Script
The script responsible for increasing your xp, and level. 
Contains the AddXp method. You need to pass in a float as an argument.
XpLevelAdjust will increase the XpToNextLevel by a certain amount each time the player levels up.
Requires a Xp and Level UI Text, but this can be easily changed in code. 

## XP_Lvl_Delegate
Requested in the comments of the video tutorial, this script is based on. 
This script is the same as the XP_Lvl script, but it includes a Delegate, Event, and Unity Event 
for when the player adds XP.

## Delegate_Tester
Example script that the Delegate, Event, and Unity Event from the XP_Lvl_Delegate script hooks into. 
