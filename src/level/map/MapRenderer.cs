using Godot;
/**
* Responsible for rendering generated maps to a physical scene.
*/
public class MapRenderer {
	public static void RenderMap(MapData mapData, TileMapLayer tileMap){
		for (int x = 0; x < mapData.Width; x++){
			for (int y = 0; y < mapData.Height; y++){
				TileType tileType =  mapData.GetTile(x, y);
				Vector2I coords= new Vector2I(x, y);
				
				switch (tileType){
					case TileType.Spawn:
						mapData.StartPosition = coords;
						// TODO setting tiles
						break;
					default:
						// do something...
						break;
				}
			}
		}
	}
}
