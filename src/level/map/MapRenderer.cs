public class MapRenderer {
	public static void RenderMap(MapData mapData, TileMapLayer tileMap){
		for (int x = 0; x < mapData.width; x++){
			for int(y = 0; y < mapData.height; y++){
				TileType tileType =  mapData.getTile(x, y);
				Vector2I coords= new Vector2I(x, y);
				
				switch (tileType){
					case TileType.Spawn:
						mapData.StartPosition(coords);
						// TODO setting tiles
				}
			}
		}
	}
}
