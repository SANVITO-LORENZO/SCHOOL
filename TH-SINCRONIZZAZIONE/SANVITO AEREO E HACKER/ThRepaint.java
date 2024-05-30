public class ThRepaint extends Thread {
    MyPanel panel;

    public ThRepaint(MyPanel panel) {
        this.panel = panel;
    }

    @Override
    public void run() {
        while (true) {
            panel.repaint();
            try {
                Thread.sleep(33);
            } catch (Exception e) {

            }
        }
    }

}
