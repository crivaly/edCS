using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		Label label=new Label("este lo he añadido por código");
		label.Visible = true;
		vBoxMain.Add(label);




	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButtonAceptarClicked (object sender, EventArgs e)
	{

		//throw new NotImplementedException ();
		labelSaludo.Text = "hola " + entryNombre.Text;
	}
}
