
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Label labelSaludo;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Label label2;
	private global::Gtk.Entry entryNombre;
	private global::Gtk.Button buttonAceptar;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelSaludo = new global::Gtk.Label ();
		this.labelSaludo.Name = "labelSaludo";
		this.labelSaludo.LabelProp = global::Mono.Unix.Catalog.GetString ("Hola Mundo");
		this.vbox1.Add (this.labelSaludo);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelSaludo]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Introduce tu nombre");
		this.hbox1.Add (this.label2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entryNombre = new global::Gtk.Entry ();
		this.entryNombre.CanFocus = true;
		this.entryNombre.Name = "entryNombre";
		this.entryNombre.Text = global::Mono.Unix.Catalog.GetString ("tu nombre");
		this.entryNombre.IsEditable = true;
		this.entryNombre.InvisibleChar = '•';
		this.hbox1.Add (this.entryNombre);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNombre]));
		w3.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonAceptar = new global::Gtk.Button ();
		this.buttonAceptar.CanFocus = true;
		this.buttonAceptar.Name = "buttonAceptar";
		this.buttonAceptar.UseUnderline = true;
		this.buttonAceptar.Label = global::Mono.Unix.Catalog.GetString ("Aceptar");
		this.hbox1.Add (this.buttonAceptar);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonAceptar]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonAceptar.Clicked += new global::System.EventHandler (this.OnButtonAceptarClicked);
	}
}