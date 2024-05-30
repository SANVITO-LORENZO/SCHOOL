/**
* @author  sanvito lorenzo, lorisanvi2000gmail.com
* @version 1.0
* @file JData.java 
* 
* @brief classe data
*
*/

/** 
* @class JData.java 
* 
* @brief classe che mi permette di gestire una data
* 
* caratterizata da un array formato da tre elementi il primo conterra il giorno il secondo il mese e il terzo l'anno
*/ 

public class JData {
    /*attributo vett che conterra giorno mede ed anno */
    private int[] vett;

    /**
     * costruttore parametrico che imposta il giorno, mese ed annno in un array con i dati passati come parametri
     * @param g giorno passato come parametro
     * @param m mese passato come parametro
     * @param a anno passato come parametro
     */
    public JData(int giorno, int mese,int anno){
        vett= new int[3];
        vett[0]=giorno;
        vett[1]=mese;
        vett[2]=anno;
    }

    /**
     * costruttore non parametrico
     */
    public JData(){
        vett= new int[3];
        vett[0]=0;
        vett[1]=0;
        vett[2]=0;
    }

    /**
     * metodo che ritorna il giorno
     * @return la prima cella dell'array che contiene il giorno
     */
    public int getGiorno(){
        return vett[0];
    }

    /**
     * metodo che ritorna il mese
     * @return la seconda cella dell'array che contiene il mese
     */
    public int getMese(){
        return vett[1];
    }  

    /**
     * metodo che ritorna l'anno
     * @return la terza cella dell'array che contiene l'anno
     */
    public int getAnno(){
        return vett[2];
    }   
    
    /**
     * metodo che mi ritorna l'array contenete la data
     * @return array contenente giorno mese ed anno
     */
    public int[] getData(){
        return vett;
    }

        /**
     * metodo che restituisce  una stringa contenete la data completa 
     * @return data
     */
    public String toString(){
        String tmp="";
        tmp+= "DATA:\n" + "giorno: " + vett[0] + "\n mese: "+ vett[1] + "\n anno: " + vett[2] + "\n";
        return tmp;
    }
}
