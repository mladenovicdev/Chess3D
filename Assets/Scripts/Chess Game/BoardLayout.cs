using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TeamColor
{
    Black , White
}

public enum PieceType
{
    Pawn, Bishop, Knight, Rook, Queen, King
}

[CreateAssetMenu(menuName = "ScriptableObjects/Board/Layout")]
public class BoardLayout : ScriptableObject 
{
    [Serializable]
    private class BoardSquareSetup
    {
        public Vector2Int position;
        public PieceType pieceType;
        public TeamColor teamColor;
    }

    [SerializeField]
    private BoardSquareSetup[] boardSquares;

    public int GetPiecesCount()
    {
        return boardSquares.Length;
    }

    //Coords of figure via index
    public Vector2Int GetSquareCoordsAtIndex(int index)
    {
        return new Vector2Int(boardSquares[index].position.x - 1, boardSquares[index].position.y - 1);
    }

    //returns name of the figure as string via index
    public string GetSquarePieceNameAtIndex(int index)
    {
        return boardSquares[index].pieceType.ToString();
    }

    //returns figure color via index
    public TeamColor GetSquareColorAtIndex(int index)
    {
        return boardSquares[index].teamColor;
    }
}
