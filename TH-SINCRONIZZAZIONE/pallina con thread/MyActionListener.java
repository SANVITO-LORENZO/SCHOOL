import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MyActionListener implements ActionListener{

    MyPanel pannello;

    public MyActionListener(MyPanel pannello) {
        this.pannello = pannello;
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        pannello.repaint();
    }
    
}
