using System;
using Godot;

/**
* Responsible for generating seed-based maps upon given MapData
*/
public class MapGenerator {
	private int seed;
	private Random rng;
	
	/**
	* For providing a manual seed.
	*/
	public MapGenerator(int seed){
		this.seed = seed;
		this.rng = new Random((int) this.seed);
	}
	
	/**
	* For dinamically generated seeds.
	*/
	public MapGenerator(){
	// TODO generate seed dinamically	
	// this.seed;
		this.rng = new Random(this.seed);
	}
	
	public void GenerateMap(MapData mapData){
		for (int x = 0; x < mapData.Width; x++){
			for (int y = 0; y < mapData.Height; y++){
				if (x == 0 && y == 0){
					mapData.SetTile(x, y, generateSpawn());
				} else if (x == mapData.Width - 1 && y == mapData.Height - 1){
					mapData.SetTile(x, y, generateGoal());
				} else {
					mapData.SetTile(x, y, generateTile());
				}
			}
		}
	}
	
	private TileType generateTile(){
		return TileType.Transposable;
	}
	
	private TileType generateSpawn(){
		return TileType.Spawn;
	}
	
	private TileType generateGoal(){
		return TileType.Goal;
	}
	
}
