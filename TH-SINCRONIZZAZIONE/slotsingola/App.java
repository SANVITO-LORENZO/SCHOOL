import java.awt.Dimension;

import javax.swing.JFrame;

public class App {
    public static void main(String[] args) {
        JFrame frame=new JFrame();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        MyPanel panel= new MyPanel();
        ThRepaint tr= new ThRepaint(panel);

        tr.start();
        panel.setSize(new Dimension(500,500));

        MyMouseListener l1= new MyMouseListener(panel);

        panel.addMouseListener(l1);

        frame.add(panel);
        frame.setSize(new Dimension(500,500));
        frame.setVisible(true);
    }
}
