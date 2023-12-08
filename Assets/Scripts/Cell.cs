using UnityEngine;

[System.Serializable]
public class Cell
{
    public Vector3 pos { get; private set; } = Vector3.zero;
    public Entity entity;
    [HideInInspector] public (int, int) gridPos;


    public Cell(Vector3 pos, (int, int) gridPos)
    {
        this.pos = pos;
        this.gridPos = gridPos;
    }

    public void DeleteEntity()
    {
        this.entity = null;
    }

    public void SetEntity(Entity entity)
    {
        this.entity = entity;
    }

}
