package Chess;

public class PiecePosition {

        /**
         * Esta funcion devuelve si una fila y una columna están dentro del tablero o no
         * @param column
         * @param row
         * @return 
         */
	public static boolean isAvailable(int column, int row) {
		return column >= 0 && column < 8 && row >= 0 && row < 8;
	}

	/**
         * Esta funcion devuelve si la posición a la que quieres moverte
         * está dentro del tablero o no
         * @param position
         * @param columnIncrement
         * @param rowIncrement
         * @return 
         */
	static boolean isAvailable(PiecePosition position, int columnIncrement, int rowIncrement) {
		if (position == null)
			return false;
		
		int newColumn = position.getColumn() + columnIncrement;
		int newRow = position.getRow() + rowIncrement;
		return isAvailable(newColumn, newRow);
	}

	/**
         * Esta funcion devuelve si una posición en la que estás, está dentro del tablero o no
         * @param position
         * @return 
         */
	static boolean isAvailable(PiecePosition position) {
		if (position == null)
			return false;
		return isAvailable(position.getColumn(), position.getRow());
	}

	private int column, row;

	/**
         * Constructor que asigna valores a al columna y la fila 
         * @param column
         * @param row 
         */
	public PiecePosition(int column, int row) {
		this.column = column;
		this.row = row;
	}
	
	/**
         * Devuelve la columna en la que estás
         * @return 
         */
	public int getColumn() {
		return column;
	}

	/**
         * Devuelve la final en la que te encuetras
         * @return 
         */
	public int getRow() {
		return row;
	}
	
        /**
         * Comprueba si los valores de columna y fila pertenecen al tablero
         * y si estos valores pertenecen al tablero los asigna a columna y fila respectivamente
         * @param column
         * @param row
         * @return 
         */
	public boolean setValues(int column, int row) {
		if (isAvailable(column, row)) {
			this.column = column;
			this.row = row;			
			return true;
		}
		return false;
	}
	
	/**
         * devuelve la pieza en la nueva posicion
         * @param columnCount
         * @param rowCount
         * @return 
         */
	public PiecePosition getDisplacedPiece(int columnCount, int rowCount) {		
		if (!isAvailable(this, columnCount, rowCount))
			return null;
		int newColumn = getColumn() + columnCount;
		int newRow = getRow() + rowCount;
		return new PiecePosition(newColumn, newRow);
	}
	
	/**
         * Clona la columna y la fila de la pieza
         * @return 
         */
	public PiecePosition clone() {
		return new PiecePosition(column, row);
	}
	
	/**
         * Compara la columna clonada con la columna original y 
         * compara la fila clonada con la fila original
         * devuelve si son iguales
         * @param aPosition
         * @return 
         */
	public boolean equals(PiecePosition aPosition) {
		return aPosition.getColumn() == getColumn() && aPosition.getRow() == getRow();
	}
}
