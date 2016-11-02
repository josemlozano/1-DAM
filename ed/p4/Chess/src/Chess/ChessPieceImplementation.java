package Chess;

public class ChessPieceImplementation implements ChessPiece {
    
    Color myColor;
    Type myType;
    boolean move = false;
    
    public ChessPieceImplementation (Color newColor, Type newType){
        myColor = newColor;
        myType = newType;
    }
    
    @Override
    public Color getColor() {
        return myColor; 
    }

    @Override
    public Type getType() {
        return myType;
    }

    @Override
    public void notifyMoved() {
        move = true;
    }

    @Override
    public boolean wasMoved() {
        return move;
    }

    @Override
    public PiecePosition[] getAvailablePositions(ChessBoard aBoard) {
        if(myType == Type.PAWN){
            return ChessMovementManager.getAvailablePositionsOfPawn(this, aBoard);
        }
        else if(myType == Type.BISHOP){
            return ChessMovementManager.getAvailablePositionsOfBishop(this, aBoard);
        }
        else if(myType == Type.KING){
            return ChessMovementManager.getAvailablePositionsOfKing(this, aBoard);
        }
        else if(myType == Type.KNIGHT){
            return ChessMovementManager.getAvailablePositionsOfKnight(this, aBoard);
        }
        else if(myType == Type.QUEEN){
            return ChessMovementManager.getAvailablePositionsOfQueen(this, aBoard);
        }
        else {
            return ChessMovementManager.getAvailablePositionsOfRook(this, aBoard);
        }
    }
    
}        