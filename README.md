# Unity-A-Star
Most implementations I've found are either pretty large codebases, awefully written or even worse: both!
So, here's a lightweight, simple implementation of the classic A* algorithm in Unity.

I've left the most important fields public so you can see the constructed paths directly in the editor.

**Instructions**

  1. Throw the 'AStarMaster' component on a Game Object.
  2. Throw the 'Actor' component on a Game Object representing your Entity to follow the constructed path. 
  3. Asign the actor Game Object to the 'Actor' field of the 'AStarMaster' component. *You're good to go!*

Note: No visuals included, you might want to visualize the grid for example. (e.g. using Unity's low level Graphics library)
