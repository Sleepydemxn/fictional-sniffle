using UnityEngine;

public class TVOnCommand : MonoBehaviour, ICommand
{
    public tv TVSet;
    public Color _color;
    public Vector2 pos;
    
    public TVOnCommand(tv tvset, Color col, Vector2 _pos)
    {
        TVSet = tvset;
        _color = col;
        pos = _pos;
    }
    
    public void Execute()
    {
        TVSet.On(_color, pos);
    }

    public void Undo()
    {
        TVSet.Off(_color, pos);
    }
}
