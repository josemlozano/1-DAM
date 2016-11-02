package tresenraya;

class  NoughtsAndCrossesBoardImplementation implements NoughtsAndCrossesBoard{
    boolean game;
    String[][] board = null;
    Color color;
    
    /**
     * constructor por defecto 
     */
    public NoughtsAndCrossesBoardImplementation(){
        board = new String[3][3];
        board[0][0] = "R";
        board[1][0] = "V";
        board[2][0] = "B";
        
        board[0][1] = "B";
        board[1][1] = "R";
        board[2][1] = "V";
        
        board[0][2] = "R";
        board[1][2] = "V";
        board[2][2] = "B";
        
    }
    
    /**
     * comprueba si se ha hecho tres en raya
     * @return true or false
     */
    @Override
    public boolean isGameOver() {
        
        for (int i = 0; i < 3; i++) {
            if (board[i][0] != "V" && board[i][0] == board[i][1] && board[i][0] == board[i][2]){
                return true;
            }
        }
        
        for (int i = 0; i < 3; i++) {
            if (board[0][i] != "V" && board[0][i] == board[1][i] && board[0][i] == board[2][i]){
                return true;
            }
        }
        
        if (board[0][0] != "V" && board[0][0] == board[1][1] && board[0][0] == board[2][2]){
            return true;
        }
        
        if (board[0][2] != "V" && board[0][2] == board[1][1] && board[0][2] == board[2][0]){
            return true;
        }
        
        return false;
    }
    
    /**
     * mueve la pieza a la nueva posicion
     * @param fromX
     * @param fromY
     * @param toX
     * @param toY
     * @return true si puede moverla, or false en caso de no poder moverla
     */
    @Override
    public boolean movePiece(int fromX, int fromY, int toX, int toY) {
        if(toX >= 0 & toX <3 && toY >= 0 & toY <3){
            if (board[toX][toY] == "V"){
                String piece = board[toX][toY];
                board[toX][toY] = board[fromX][fromY];
                board[fromX][fromY] = piece;
                return true;
            }
        }
        
        return false;
    }
    
    /**
     * comprueba si existe pieza
     * @param x
     * @param y
     * @return red, white or void
     */
    @Override
    public Color getPieceAt(int x, int y) {
        if(x >= 0 && x < 3 && y >= 0 && y < 3){
            if (board[x][y] == "R"){
                return NoughtsAndCrossesBoard.Color.RED;
            }
            else if (board[x][y] == "B"){
                return NoughtsAndCrossesBoard.Color.WHITE;
            }
        }
        
        return NoughtsAndCrossesBoard.Color.VOID;
    }

    /**
     * A esta funcion se llega tras haber comprobado que existe una pieza,
     * de lo contrario no llegaria a esta funcion, y dado que le tablero siempre
     * tiene espacios libres, no hay que comprobar si la pieza se puede mover.
     * @param x
     * @param y
     * @return true
     */
    @Override
    public boolean canMovePieceAt(int x, int y) {
        return true;
    }
    
}