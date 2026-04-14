using Godot;
using System;

public partial class Level : Node
{
	[Export] TileMapLayer tileMapLayer;
	private MapData mapData;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		mapData = new MapData(10, 10);
		// TODO add seed support
		MapGenerator mapGenerator = new MapGenerator();
		mapGenerator.GenerateMap(mapData);
		MapRenderer.RenderMap(mapData, tileMapLayer);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
