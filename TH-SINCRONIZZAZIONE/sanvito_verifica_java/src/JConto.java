/**
* @author  sanvito lorenzo, lorisanvi2000gmail.com
* @version 1.0
* @file JConto.java
* 
* @brief classe conto
*
*/

/** 
* @class JConto.java
* 
* @brief claase che mi permette di gestire un conto
* 
* caratterizzata da un array di movimenti
*/ 
public class JConto {
    /* */
    private final int MAXEL = 50;
    /* attributo array di movimenti */
    private JMovimenti[] vett;
    /*attributo numero di elementi del vettore */
    private int numEl;
    /*attributo nome dell'intestatario */
    private String nome;


    /**
     * costruttore parametrico
     * @param nome nome dell'intestatario
     */
    public JConto(String nome){
        setNome(nome);
        numEl=0;
        vett= new JMovimenti [MAXEL];
    }

    /**
     * costruttore non parametrico
     */
    public JConto(){
        setNome("");
        numEl=0;
        vett= new JMovimenti [0];
    }

    /**
     * metodo che mi imposta il nome con il data passato come parametro
     * @param nome nome passato come parametro
     */
    public void setNome(String nome){
        this.nome=nome;
    }
    
    /**
     * metodo che mi restituisce il nome dell'intestatario
     * @return nome dell'intestatario 
     */
    public String getNome(){
        return nome;
    }

    /**
     * metodo che aggiunge all'array di movimenti un movimento passato come parametro
     * @param movimento movimento passato come parametro
     */
    public void addMovimento(JMovimenti movimento){
        vett[numEl]=movimento;
        numEl++;
    }

    /**
     * metodo che ritorna il saldo
     * @return saldo = somma algebrica dei movimenti
     */
    public int getSaldo(){
        int tmp=0;
        for(int x=0; x<numEl; x++){
            tmp+=vett[x].getImporto();
        }
        return tmp;
    }

    /**
     * metodo che ritorna il saldo
     * @return saldo = somma algebrica dei movimenti
     */
    public String getEstratto(){
        String tmp="";
        for(int x=0; x<numEl; x++){
            tmp+=" IMPORTO " + (x+1) + "\n";
            tmp+=vett[x].toString();
        }
        return tmp;
    }

    /**
     * metodo che elimina tutti i movimenti accaduti in una certa data
     * @param giorno giorno passato come parametro
     * @param mese mese passato come parametro
     * @param anno anno passato come parametro
     */
    public void eliminaMovimento(int giorno, int mese, int anno){
        for(int x=0; x<numEl; x++){
            if(vett[x].getData().getGiorno()==giorno){
                if(vett[x].getData().getMese()==mese){
                    if(vett[x].getData().getAnno()==anno){
                        vett[x]= new JMovimenti();
                    }
                }
            }
        }
 
    }
    

}
