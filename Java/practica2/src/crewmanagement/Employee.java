package crewmanagement;

public class Employee {
    
    String name;
    String surname;
    String DNI;
    Turn turno;
    Turn[] turns = null;
    final static String[] letters = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", 
        "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"};
    
    /**
     * constructor  default
     */
    public Employee(){
        name = "Javier";
        surname = " Morcillo Marín";
        DNI = "68564958A";
    }
    
    /**
     * overload contructor without DNI
     * @param aName
     * @param aSurname 
     */
    public Employee(String aName, String aSurname){
        name = (aName == null) ? null : aName;
        surname = (aSurname == null) ? null : aSurname;
    }
    
    /**
     * overload constructor with DNI
     * @param aDNI
     * @param aName
     * @param aSurname 
     */
    public Employee(String aDNI, String aName, String aSurname){
        if (aDNI != null){
            String letter = "";
            String numDNI = "";

            for (int i = 0; i < aDNI.length(); i++) {
                if (aDNI.charAt(i) >= '0' && aDNI.charAt(i) <= '9'){
                    numDNI += aDNI.charAt(i);
                }
                else{
                    letter += aDNI.charAt(i);
                }
            }

            if (letter.length() == 1){
                int newDNI = Integer.parseInt(numDNI);
                int r = newDNI % 23;
                if (letters[r].equals(letter.toUpperCase())) {
                    DNI = aDNI;
                    name = (aName == null) ? null : aName;
                surname = (aSurname == null) ? null : aSurname;
                }
            }
        }
    }
    
    /**
     * enter a new name
     * @param aName 
     */
    public void setName(String aName){
        name = (aName == null) ? null : aName;
    }
    
    /**
     * return name
     * @return 
     */
    public String getName(){
        return name;
    }
    
    /**
     * enter new surname
     * @param aSurname 
     */
    public void setSurname(String aSurname){
        surname = (aSurname == null) ? null : aSurname;
    }
    
    /**
     * return surname
     * @return 
     */
    public String getSurname(){
        return surname;
    }
    
    /**
     * return employee's full name
     * @param nameInUpperCase
     * @param surnameInUpperCase
     * @return 
     */
    public String getFullName(boolean nameInUpperCase, boolean surnameInUpperCase){
        if(name == null && surname == null){
                return "";
        }
        else{
            if (nameInUpperCase && surnameInUpperCase){
                if(surname == null){
                    return name.toUpperCase();
                }
                else if ( name == null){
                    return surname.toUpperCase();
                }
                return name.toUpperCase() + ", " + surname.toUpperCase();
            }
            else if (nameInUpperCase){
                if(surname == null){
                    return name.toUpperCase();
                }
                else if ( name == null){
                    return surname;
                }
                return name.toUpperCase() + ", " + surname;
            }

            else if (surnameInUpperCase){
                if(surname == null){
                    return name;
                }
                else if ( name == null){
                    return surname.toUpperCase();
                }
                return name+ ", " + surname.toUpperCase();
            }
            else{
                if(surname == null){
                    return name;
                }
                else if ( name == null){
                    return surname;
                }
                return name + ", " + surname;
            }
        }
    }
    
    /**
     * enter a valid DNI
     * @param aDNI 
     */
    public void setDNI(String aDNI){
        if (aDNI != null){
            String letter = "";
            String numDNI = "";

            for (int i = 0; i < aDNI.length(); i++) {
                if (aDNI.charAt(i) >= '0' && aDNI.charAt(i) <= '9'){
                    numDNI += aDNI.charAt(i);
                }
                else{
                    letter += aDNI.charAt(i);
                }
            }

            if (letter.length() == 1){
                int newDNI = Integer.parseInt(numDNI);
                int r = newDNI % 23;
                if (letters[r].equals(letter.toUpperCase())) {
                    DNI = aDNI;
                }
            }
        }
    }
    
    /**
     * return DNI
     * @return 
     */
    public String getDNI(){
        return DNI;
    }
    
    /**
     * enter a new turn
     * @param turno 
     */
    public void addTurn (Turn turno){
        if (turno != null){
            turns = addElement(turns, turno);
        }
        
    }
    
    /**
     * revome turn of a day
     * @param aDay 
     */
    public void removeTurn (String aDay){
        if(getTurnCount() != 0){
            for (int i = 0; i < getTurnCount(); i++) {
                if(turns[i].day.equals(aDay.toUpperCase())){
                    turns = removeElement(i);
                }
            }
        }
    }
    
    /**
     * return turns amount
     * @return 
     */
    public int getTurnCount(){
        if(turns != null)
        return turns.length;
        else 
            return 0;
    }
    
    /**
     * return turns
     * @param anIndex
     * @return 
     */
    public Turn getTurnAt (int anIndex){
        if (turns [anIndex] == null){
            return null;
        }
        else{
            return turns[anIndex];
        }
    }
    
    /**
     * return all truns of a employee
     * @return 
     */
    public Turn[] getTurns(){
        return turns;
    } 
    
    /**
     * Enter a new turn in array
     * @param turns
     * @param element
     * @return 
     */
    public Turn[] addElement (Turn[] turns, Turn element){
        int size = (int)getTurnCount();
        
        Turn[] temp = null;
        
        if(turns == null){
           temp = new Turn [1];
           temp[size]=element;
        }
        else if (size < 7){
            temp = new Turn [turns.length+1]; 
            for (int i = 0; i < temp.length-1; i++) {
                temp[i]=turns[i];
            }
            temp[size]=element;
        }
        else{
            return turns;
        }
        return temp;
    }
    
    /**
     * remove a turn
     * @param pos
     * @return 
     */
    public Turn[] removeElement (int pos){
        
        Turn[] temp = null;
        int cont = getTurnCount();
        
        if(cont == 0){
           temp = null; 
        }
        else if (cont > 1){
            temp = new Turn [cont-1]; 
            for (int i = 0; i < pos; i++) {
                temp[i] = turns[i];
            }
            for (int j = pos; j < cont - 1; j++) {
                temp[j] = turns [j+1];
            }
        }
        return temp;
    }
}
