
using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    public pult myPult;
    public tv myTv;
    public Vector2 move;
    private TVOnCommand _comand;
    public List<TVOnCommand> ListComands = new List<TVOnCommand>();
    private Color col1;
    private Color[] col = {Color.red, Color.blue, Color.black, Color.green, Color.yellow, Color.white, Color.grey};
    public Vector2 undoMove;

    private void Update()
    {
        if (Input.GetKey("w")) move = new Vector2(0, 1);
        if (Input.GetKey("s")) move = new Vector2(0, -1);
        if (Input.GetKey("a")) move = new Vector2(-1, 0);
        if (Input.GetKey("d")) move = new Vector2(1, 0);
    }

    public void TvComandos()
    {
        col1 = col[Random.Range(0, 7)];
        _comand = new TVOnCommand(myTv, col1, move); 
        myPult.SetComand(_comand);
        myPult.PressButtonOn();
        ListComands.Add(_comand);
    }
  
    public void Otkat()
    {
        if (ListComands.Count <= 1) return;
        _comand = ListComands[ListComands.Count - 2];
        col1 = _comand._color;
        move = _comand.pos;
        myPult.SetComand(_comand);
        myPult.PressButtonOn();
        ListComands.RemoveAt(ListComands.Count - 1);
    }
}
