import java.awt.Color;

public class Pallina {

    /**attributi */
    private int x,y;
    private int height,width;    
    private Color backgroundColor;
    private Color borderColor;
    private int direzione;

    /**costruttore */
    public Pallina(int x, int y, int height, int width, int direzione) {
        this.x = x;
        this.y = y;
        this.height = height;
        this.width = width;
        this.backgroundColor=Color.red;
        this.borderColor=Color.black;
        this.direzione=direzione;
    }

    /**metodi get dei vari attributi */
    public int getX() {
        return x;
    }
    public int getY() {
        return y;
    }    
    public int getHeight() {
        return height;
    }
    public int getWidth() {
        return width;
    }
    public Color getBackgroundColor() {
        return backgroundColor;
    }
    public Color getBorderColor() {
        return borderColor;
    }
    
    public int getDirezione() {
        return direzione;
    }

    /**metodi set dei vari attributi */
    public void setX(int x) {
        this.x = x;
    }
    public void setY(int y) {
        this.y = y;
    }
    public void setHeight(int height) {
        this.height = height;
    }
    public void setWidth(int width) {
        this.width = width;
    }
    public void setBackgroundColor(Color backgroundColor) {
        this.backgroundColor = backgroundColor;
    }
    public void setBorderColor(Color borderColor) {
        this.borderColor = borderColor;
    }

    public void setDirezione(int direzione) {
        this.direzione = direzione;
    }

}
