/* Worldclass for modeling the entire in-game world
 */

class World {
  public Space entry { get; }
  
  public World () {
    Space entry    = new Space("gate");
    Space path = new Space("path");
    Space picnic     = new Space("picnic");
    Space forest      = new Space("forest");
    Space playground  = new Space("playground");
    Space recycle        = new Space("recycle");
    
    entry.AddEdge("gate", path);
    path.AddEdge("path", picnic);
    picnic.AddEdge("forest", forest);
    picnic.AddEdge("picnic", playground);
    picnic.AddEdge("g", recycle);
    forest.AddEdge("forest", picnic);
    playground.AddEdge("playground", picnic);
    recycle.AddEdge("recycle", picnic);
    
    this.entry = entry;
  }
  
  public Space GetEntry () {
    return entry;
  }
  
}

