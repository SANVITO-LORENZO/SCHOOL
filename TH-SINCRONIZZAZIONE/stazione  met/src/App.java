import java.util.Scanner;

public class App{

    public static void main(String[] args) {
       

       //TUTTE LE SET

        Scanner s= new Scanner(System.in);
        System.out.println("QUANTI VALORI: ");
        int NValori=s.nextInt();
        StazioneMeteoroliga sm= new StazioneMeteoroliga(NValori);

        int i=0;
        while(i<NValori){
            System.out.println("DAMMI IL VALORE " + i + " :");
            float tmep=s.nextFloat();
            if(sm.setTemperatura(tmep, i)){
                System.out.println("Temperatura " + tmep+ "impostata con successo");
                i++;
            }
            else{
                System.out.println("Errore nell'impostazione della temperatura"+ tmep);
            }
        }


    }
}