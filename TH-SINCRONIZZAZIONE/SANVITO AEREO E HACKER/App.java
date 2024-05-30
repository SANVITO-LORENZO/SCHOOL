import javax.swing.JFrame;
import javax.swing.SwingUtilities;

public class App {

    public static void main(String[] args) {
        Agenzia a1= new Agenzia("A1");
        Agenzia a2= new Agenzia("A2");
        Agenzia a3= new Agenzia("A3");
        Agenzia a4= new Agenzia("A4");
        Agenzia a5= new Agenzia("A5");

        ThAgenzia thA1= new ThAgenzia(a1);
        ThAgenzia thA2= new ThAgenzia(a2);
        ThAgenzia thA3= new ThAgenzia(a3);
        ThAgenzia thA4= new ThAgenzia(a4);
        ThAgenzia thA5= new ThAgenzia(a5);

        ThHacker thH1 = new ThHacker();
        ThHacker thH2 = new ThHacker();

        thA1.start();
        thA2.start();
        thA3.start();
        thA4.start();
        thA5.start();
        thH1.start();
        thH2.start();

        MyPanel pannello = new MyPanel();
        SwingUtilities.invokeLater(new Runnable() {
            public void run()
            {
                createAndShowGUI(pannello);
            }
        });


        try {
            thA1.join();
            thA2.join();
            thA3.join();
            thA4.join();
            thA5.join();
            thH1.join();
            thH2.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        Stato stato= Stato.ottieniIstanza();
        if(stato.stato==2)
            System.out.println("COMPLETATO");
        else if (stato.stato==3)
            System.out.println("HACKERATO");

    }

    private static void createAndShowGUI(MyPanel pannello)
    {
        JFrame f = new JFrame();
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        ThRepaint tr= new ThRepaint(pannello);
        tr.start();
        pannello.setSize(800, 800);
        f.add(pannello);
        f.setSize(800,800);
        f.setVisible(true);
    }
}