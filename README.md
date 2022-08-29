# MuhammadRaihanAziz-Tugas7
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)


1. For audio resources, only used BGM is loaded to the game. This can reduce memory usage of the game.

2. Adding object pooling for mushroom spawner

3. Adding atlas for main menu button making the batches 3 instead of 4

4. Tried to use static batching, but it makes SetPassCall to go up significantly so I decided not to used it
