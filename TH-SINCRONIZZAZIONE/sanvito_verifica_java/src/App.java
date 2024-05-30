/**
* @author  sanvito lorenzo, lorisanvi2000gmail.com
* @version 1.0
* @file App.java 
* 
* @brief main dimostrativo che utilizza tutti imetodi della classe JMovimenti
*
*/
/** @mainpage CONTO BANCARIO (@mainpage CONTO BANCARIO)
* 
*
*  permette di gestire un conto bancario

* @section JConto (JConto)
* 
*permette di gestire i movimenti di un utente
* @section JMovimenti (JMovimenti)
* 
*permette di creare i movimenti dell'utente
*
*
* @section JData (JData)
* 
*permette di creare la data di un movimento
*
*/


public class App{
    public static void main(String[] args) {
        JData data1=new JData(10,11,2020);
        JData data2=new JData(10,11,2022);

        JMovimenti mov1=new JMovimenti(data1,1000,"retta scuola");
        JMovimenti mov2=new JMovimenti(data2,-50,"retta scuola");

        JConto conto=new JConto("pablito");

        conto.addMovimento(mov1);
        conto.addMovimento(mov2);


        System.out.println("SALDO \n");
        System.out.println(conto.getSaldo());

        System.out.println(" \n ESTRATTO \n");
        System.out.println(conto.getEstratto());

        conto.eliminaMovimento(10,11,2020);

        System.out.println("SALDO \n");
        System.out.println(conto.getSaldo());

        System.out.println(" \n ESTRATTO \n");
        System.out.println(conto.getEstratto());

        
    }
}