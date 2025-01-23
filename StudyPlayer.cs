// Just studying code
// Define direction changes for movement in the Y and X axes
using Test03;

int[] frontY = new int[] { -1, 0, 1, 0 };  // Y-axis movement based on direction: Up, Left, Down, Right
int[] frontX = new int[] { 0, -1, 0, 1 };  // X-axis movement based on direction: Up, Left, Down, Right
int[] rightY = new int[] { 0, -1, 0, 1 };  // Y-axis movement for turning right from each direction
int[] rightX = new int[] { 1, 0, -1, 0 };  // X-axis movement for turning right from each direction

// Add the initial position to the list of points
_points.Add(new Pos(posY, posX));

// Continue executing until reaching the destination
while (PosY != board.DestY || PosX != board.DestX)
{
    // 1. Check if we can move right from the current direction
    if (_board.Tile[PosY + rightY[_dir], PosX + rightX[_dir]] == board.TileType.Empty)
    {
        // Rotate 90 degrees to the right
        _dir = (_dir - 1 + 4) % 4;
        // Move forward one step
        PosY = PosY + frontY[_dir];
        PosX = PosX + frontX[_dir];
        // Add the new position to the list of points
        _points.Add(new Pos(PosY, PosX));
    }
    // 2. If moving right isn't possible, check if we can move forward
    else if (_board.Tile[PosY + frontY[_dir], PosX + frontX[_dir]] == board.TileType.Empty)
    {
        // Move forward one step
        PosY = PosY + frontY[_dir];
        PosX = PosX + frontX[_dir];
        // Add the new position to the list of points
        _points.Add(new Pos(PosY, PosX));
    }
    else
    {
        // If neither moving right nor forward is possible, rotate 90 degrees to the left
        _dir = (_dir + 1 + 4) % 4;
    }
}
