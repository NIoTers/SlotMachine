using System.Windows.Forms;

public class TransparentLabel : Label
{
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
           
            cp.ExStyle |= 0x20;  
            return cp;
        }
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
    }
}
