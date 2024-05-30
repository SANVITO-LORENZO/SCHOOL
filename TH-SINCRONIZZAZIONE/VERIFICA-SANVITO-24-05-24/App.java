public class App {

    public static void main(String[] args) {
        ISS stazione = new ISS();
        ThTempo tempo= new ThTempo(stazione);

        stazione.start();
        tempo.start();

        try {
            stazione.join();
        } catch (Exception e) {}

        try {
            tempo.join();
        } catch (Exception e) {}

        int tmpMedioAntenna= stazione.getTempoMedioAntenna();
        int tmpMedioPannelli= stazione.getTempoMedioPannelli();
        int tmpMedioValvola= stazione.getTempoMedioValvola();
        int tmpMax= stazione.getMaxCambiamento();
        int tmpMin= stazione.getMinCambiamento();
        long tmpTotate= tempo.tempo;

        System.out.println("TEMPO MEDIO LAVORO ANTENNA : " + tmpMedioAntenna);
        System.out.println("TEMPO MEDIO LAVORO PANNELLI : " + tmpMedioPannelli);
        System.out.println("TEMPO MEDIO LAVORO VALVOLA : " + tmpMedioValvola);
        System.out.println("TEMPO MINIMO PER CAMBIARSI: " + tmpMin);
        System.out.println("TEMPO MASSIMO PER CAMBIARSI: " + tmpMax);
        System.out.println("TEMPO TOTALE: " + tmpTotate);
    }
}