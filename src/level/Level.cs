using Godot;
using System;

public partial class Level : Node
{
	private MapData mapData;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		mapData = new MapData(10, 10);
		mapData.generate();
		
		// TODO mapData = mapGenerator.Generate();
		MapRenderer.Render(mapData);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
