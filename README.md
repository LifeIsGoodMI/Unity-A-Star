# Unity-A-Star
Most implementations I've found are either pretty large codebases, awefully written or even worse: both!
So, here's a lightweight, simple implementation of the classic A* algorithm in Unity.

I've left the most important fields public so you can see the constructed paths directly in the editor.

Just throw the AStarMaster component on a Game Object, the Actor component on a Game Object representing your Entity following the constructed path & you're good to go!
Note: No visuals included, you might want to visualize the grid for example. (e.g. using Unity's low level Graphics library)
