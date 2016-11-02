package propertyshop;

public class Property {
    String name;
    String address;
    double contructedSurface;
    double availableSurface;
    String owner;
    String ownerAddress;
    int price;
    int cont;
    

    /**
     * Enter new name in lowercase
     * @param newName 
     */
    public void setName(String newName){
        name = (newName == null) ? null : newName.toLowerCase();
    }
    
    
    /**
     * return the name entered
     * @return 
     */
    public String getName(){
        return name;
    }
    
    
    
    /**
     * Enter new address in uppercase
     * @param newAddress 
     */
    public void setAddress (String newAddress){
        address = (newAddress == null) ? null : newAddress.toUpperCase();
    }
    
    /**
     * return the address entered
     * @return 
     */
    public String getAddress(){
        return address;
    }
    
    
    
    /**
     * Enter the constructer meter must be greater than 0
     * @param newConstructedSurface 
     */
    public void setConstructedSurface(double newConstructedSurface){
        if (newConstructedSurface > 0){
            contructedSurface = newConstructedSurface;
        }
    }
    
    /**
     * Return built meters
     * @return 
     */
    public double getConstructedSurface(){
        return contructedSurface;
    }
    
    
    
    /**
     * Enter the meters available must be greater than 0
     * @param newAvailableSurface 
     */
    public void setAvailableSurface(double newAvailableSurface){
        if (newAvailableSurface > 0){
            availableSurface = newAvailableSurface;
        }
    }
    
    /**
     * Return meters available
     * @return 
     */
    public double getAvailableSurface(){
        return availableSurface;
    }
    
    
    
    /**
     * Enter new owner
     * @param newOwner 
     */
    public void setOwner (String newOwner){
        owner = newOwner;
    }
    
    /**
     * Return new owner
     * @return 
     */
    public String getOwner (){
        return owner;
    }
    
    
    
    /**
     * Enter address owner
     * @param newOwnerAddress 
     */
    public void setOwnerAddress (String newOwnerAddress){
        ownerAddress = newOwnerAddress;
    }
    
    
    /**
     * return  address owner
     * @return 
     */
    public String getOwnerAddress (){
        return ownerAddress;
    }
    
    
    
    /**
     * Enter price
     * @param newPrice 
     */
    public void setPrice (int newPrice){
        if (newPrice > 0){
            price = newPrice;
        }
    }
    
    /**
     * return price
     * @return 
     */
    public int getPrice (){
        return price;
    }
}