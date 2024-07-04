namespace viborita;

public class Apple
{
    private Rectangle appleBody;
    private SolidBrush pencil;
    private string appleColor;
    private int x, y, width, height;


    public Rectangle AppleBody{
        get {return appleBody;}
    }
    public Apple(Random ranFood){
        x = ranFood.Next(0, 29) * 10;
        y = ranFood.Next(0, 29) * 10;
        appleColor = "#c80d0d";
        Color appleColorBody = ColorTranslator.FromHtml(appleColor);
        pencil = new SolidBrush(appleColorBody);

        width = 10;
        height = 10;

        appleBody = new Rectangle(x, y, width, height);
    }

    public void generationApple(Random ranFood){
        x = ranFood.Next(0, 29) * 10;
        y = ranFood.Next(0, 29) * 10;
    }

    public void DrawApple(Graphics papel){
        appleBody.X = x;
        appleBody.Y = y;

        papel.FillRectangle(pencil,appleBody);
    }
}
