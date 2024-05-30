/**
* @author  sanvito lorenzo, lorisanvi2000gmail.com
* @version 1.0
* @file JMovimenti.java 
* 
* @brief classe movimenti
*
*/

/** 
* @class JMovimenti.java 
* 
* @brief classe che mi permette di gestire i movimenti
* 
* oltre i metodi set e get ha un metodo tostring che mi restituisce la descrizione del movimento
*/ 

public class JMovimenti {

    /*attributo data */
    private JData data;
    /*attributo importo */    
    private int importo;
    /*attributo causale */    
    private String causale;


    /**
     * costruttore parametrico che imposta la data , l'importo e la causale con i dati passati come parametri
     * @param data data passata come parametro
     * @param importo importo passata come parametro
     * @param causale causale passata come parametro
     */
    public JMovimenti(JData data, int importo,String causale){
        setData(data);
        setImporto(importo);
        setcausale(causale);
    }

    /**
     * costruttore non parametrico imposta tutti i dati a zero
     */
    public JMovimenti(){
        this.data= new JData(0,0,0);
        this.importo=0;
        this.causale="";
    }

    /**
     * metodo che imposta la data con il valore passato come parametro
     * @param data data passata come parametro
     */
    public void setData(JData data){
        this.data=data;
    }

    /**
     * metodo che imposta l'importo con il valore passato come parametro
     * @param importo importo passato come parametro
     */
    public void setImporto(int importo){
        this.importo=importo;
    }

    /**
     * metodo che imposta la causale con il valore passato come parametro
     * @param causale causale passata come parametro
     */
    public void setcausale(String causale){
        this.causale=causale;
    }

    /**
     * metodo che restituisce la data
     * @return data
     */
    public JData getData(){
        return data;
    }

    /**
     * metodo che restituisce l'importo
     * @return
     */
    public int getImporto(){
        return importo;
    } 
    
    /**
     * metodo che restituisce la causale
     * @return
     */
    public String getCausale(){
        return causale;
    } 
    
    /**
     * metodo che restituisce il resoconto dei movimenti
     * @return resoconto dei movimenti
     */
    public String toString(){
        String tmp="";
        tmp+= data.toString();
        tmp+= "importo: "+ importo + "\n";
        tmp+= "causale: "+ causale + "\n";
        return tmp;
    }
}
