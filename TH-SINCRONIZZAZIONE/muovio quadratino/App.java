import javax.swing.JFrame;
import javax.swing.SwingUtilities;

public class App {

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                createAndShowGUI();
            }
        });
    }

    private static void createAndShowGUI(){
        JFrame f = new JFrame("SPOSTA IL QUADRATINO");
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        //aggingere il pannello
        MyPanel p = new MyPanel();
        f.add(p);
        MyKeyListener l = new MyKeyListener(p);
        f.addKeyListener(l);
        MyMouseListener l1=new MyMouseListener(p,p.q);
        //prendo il click del mouse dal pannello cosi parte dalle coordinate 0 0
        p.addMouseListener(l1);
        //settare la dimensione uguale al pannello
        f.pack();
        //f.setSize(500,500);
        f.setVisible(true);
    }
}