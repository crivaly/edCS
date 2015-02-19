using System;
using System.IO;
using Gtk;


public partial class MainWindow: Gtk.Window
{	
	private string filename;	
	private string content="";		//VARIABLE "TEMPORAL" PARA COMPROBAR CAMBIOS CUANDO LE DOY A NUEVO. 
								//SE COMPARA EL CONTENIDO ORIGINAL CON EL QUE HAY EN ESE MOMEMTO GUARDADO EN ESTA VARIABLE


	//construir la ventanan de visualización
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();


		//textView.Buffer.Text = File.ReadAllText ("/home/joan/edcs/prueba.txt");
		//En linux el cambio de linea es \n 
	}


	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}



	//abrir fichero
	protected void OnOpenActionActivated (object sender, EventArgs e)
	{

		//mirar apuntes del 11/02/2015
		if (!hasChanges() && !confirm ())
				return;



		FileChooserDialog fileChooserDialog = new FileChooserDialog(
			"Elige fichero para abrir",
			this,
			FileChooserAction.Open,
			Stock.Cancel,ResponseType.Cancel,
			Stock.Open,ResponseType.Accept);


			
		if (fileChooserDialog.Run () == (int)ResponseType.Accept) {
			filename = fileChooserDialog.Filename;
			content = File.ReadAllText (filename);
			textView.Buffer.Text = File.ReadAllText(filename);
		}
		fileChooserDialog.Destroy ();
	}


	//si no tiene nombre= escribir, sino GUARDAR
	protected void OnSaveActionActivated (object sender, EventArgs e)
	{
		if (filename != null) {
			File.WriteAllText (filename, textView.Buffer.Text);
		} else {
			saveAs ();
		}
	}


	//GUARDAR COMO
	private void saveAs(){
		FileChooserDialog fileChooserDialog = new FileChooserDialog (
			"Guardar como...",
			this,
			FileChooserAction.Save,
			Stock.Cancel, ResponseType.Cancel,
			Stock.Save, ResponseType.Ok);

		if ((ResponseType)fileChooserDialog.Run () == ResponseType.Ok) {
			filename = (fileChooserDialog.Filename);
			File.WriteAllText (filename, textView.Buffer.Text);
		}
		fileChooserDialog.Destroy ();
	}


	//NUEVO
	protected void OnNewActionActivated (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();       CÓDIGO POR DEFECTO AL INICIAR BOTÓN
		if (hasChanges() && !confirm ())
			return;


		textView.Buffer.Text ="";   //descarta el texto de la variable puente
		content ="";
		filename = null;

	}
	/// <summary>
	/// confirm() devuelve true si el usuario confirma que descarta los cambios
	/// --método para confirmar cambios. DESCARTAR O NO LOS CAMBIOS
	/// </summary>

	private bool confirm () {
		MessageDialog messageDialog = new MessageDialog (
			this,
			DialogFlags.DestroyWithParent,
			MessageType.Question,
			ButtonsType.YesNo,
			"hay cambios sin guardar, ¿quieres descartar los cambios?");
		ResponseType responseType = (ResponseType)messageDialog.Run ();   
		messageDialog.Destroy ();										  

		return responseType == ResponseType.Yes;    //la repuesta o es true o false
	}

	/// <summary>
	/// Si tiene cambios 
	/// </summary>
	/// <returns><c>true</c>, if changes was hased, <c>false</c> otherwise.</returns>
	private bool hasChanges(){
		return !content.Equals (textView.Buffer.Text);

}
	