package crewmanagement;

public class Turn {
    
    String day;
    int initHour;
    int finishHour;
    
    /**
     * constructor  default
     */
    public Turn(){   
    }
    
    /**
     * overload constructor
     * @param aDay 
     */
    public Turn (String aDay){
        day = aDay.toUpperCase();
    }
    
    /**
     * overload constructor
     * @param aDay
     * @param aInitHour
     * @param aFinishHour 
     */ 
    public Turn (String aDay, int aInitHour, int aFinishHour){
        day = aDay.toUpperCase();
        initHour = aInitHour;
        finishHour = aFinishHour;
    }
    
    /**
     * enter a new day
     * @param aDay 
     */
    public void setDay(String aDay){
        if (aDay != null){
            day = aDay.toUpperCase();
        }
    }
    
    /**
     * return day
     * @return 
     */
    public String getDay(){
        return day;
    }
    
    /**
     * Enter a init hour
     * @param aInitHour 
     */
    public void setInitHour (int aInitHour){
        if (aInitHour >= 0 && aInitHour < 23){
            initHour = aInitHour;
        }
    }
    
    /**
     * reutur init hour
     * @return 
     */
    public int getInitHour(){
        return initHour;
    }
    
    /**
     * enter a new finish hour
     * @param aFinishHour 
     */
    public void setFinishHour (int aFinishHour){
        if (aFinishHour >= 0 && aFinishHour < 23){
            finishHour = aFinishHour;
        }
    }
    
    /**
     * return finish hour
     * @return 
     */
    public int getFinishHour(){
        return finishHour;
    }
}
