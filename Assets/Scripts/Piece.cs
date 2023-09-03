using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public int x;
    public int y;   
    public Board board;

    public enum type
    {
        elefante,
        jirafa,
        hipo,
        mono,
        panda,
        loro,
        pinguino,
        cerdo,
        conejo,
        serpiente
    };

    public type pieceType;


    public void Setup(int x_, int y_, Board board_){
        x=x_;
        y=y_;       
        board=board_;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
