public class Portafolio {
    private int soldi;

    static Portafolio instanza=null;

    static Portafolio getInstanza(){
        if(instanza==null)
            instanza= new Portafolio();
        return instanza;
    };

    private Portafolio(){
        soldi=10;
    }

    public int getSoldi() {
        return soldi;
    }
    synchronized public void setSoldi(int soldi) {
        this.soldi = soldi;
    }
    
    synchronized boolean effettuaGiocata(){
        if(soldi>0){
            soldi--;
            return true;
        }
        else 
            return false;
    }

    synchronized void aggiungivincita(int vincita){
        soldi+=vincita;
    }

}
