using Godot;

public class MapData
{
	private readonly TileType[,] _tiles;

	public int Width { get; }
	public int Height { get; }

	public Vector2I StartPosition { get; set; }
	public Vector2I ExitPosition { get; set; }

	public MapData(int width, int height)
	{
		Width = width;
		Height = height;
		_tiles = new TileType[width, height];
	}

	public TileType GetTile(int x, int y) => _tiles[x, y];
	public void SetTile(int x, int y, TileType type) => _tiles[x, y] = type;

	public bool IsInside(Vector2I pos)
		=> pos.X >= 0 && pos.Y >= 0 && pos.X < Width && pos.Y < Height;

	public bool IsWalkable(Vector2I pos)
	{
		if (!IsInside(pos)) return false;

		TileType tile = _tiles[pos.X, pos.Y];
		return tile == TileType.Floor || tile == TileType.Start || tile == TileType.Exit;
	}
}
