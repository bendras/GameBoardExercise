## Problem description

Implement a game! Have a limited amount of time -> implement it in separate stages. 

### Stage 1

- playing board
- ability for a player to move a piece around the board.

#### Playing board, world

- The board has a fixed size of 5 squares (assume it is always square).
- The bottom left board square is indicated by the position 0 0, top left corner of the board is 0 4, bottom right is 4 0 and top right is therefore 4 4.
- The piece will start in the bottom left corner of the board facing North.

#### Input and Output

A player can issue a set of commands to the game which will result in an output of the location and direction of the piece after the moves. 

- output format (X,Y,Direction), so a piece that has moved two squares right and one north and is facing north would be in position (2,1,N). 
- Assume that the input is always correct.


#### Commands and what changes

The piece can move around the board in one of four directions ((N)orth, (E)ast, (S)outh and (W)est).

- move forward (M)
- turn left (L) by 90 degrees
- turn right (R) by 90 degrees
- If you try to make a move that would result in the piece moving off the board the move will have no effect. For example moving North when you are already at the top of the board.

